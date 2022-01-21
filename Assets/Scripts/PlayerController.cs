using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text healthDisplay;
    public Text coinDisplay;
    public float speed;
    public float startDashTime;
    private float dashTime;
    public float extraSpeed;
    private bool isDashing;
    private float input; 

    public int health; 
    public int coins;
    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        healthDisplay.text = health.ToString();
        coinDisplay.text = coins.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        if (input == 0){
            //El jugador está quieto, reproduce IDLE
            anim.SetBool("isRunning", false);
        }else {
            //El jugador se está moviendo, reproduce RUN
            anim.SetBool("isRunning", true);
        }

        if (input > 0){
            transform.eulerAngles = new Vector3(0, 0, 0);
        }else if (input < 0){
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isDashing == false){
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }

        if (dashTime <= 0 && isDashing == true){
            isDashing = false;
            speed -= extraSpeed;
        } else {
            dashTime -= Time.deltaTime;
        }
        //healthDisplay.text = health.ToString();
    }

    private void FixedUpdate() {
        input = Input.GetAxis("Horizontal");
        Debug.Log(input);
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount){
        health -= damageAmount;
        healthDisplay.text = health.ToString();
        if (health <= 0){
            healthDisplay.text = "0"; 
            Destroy(gameObject);
        }
    }

    public void GainCoins(int value){
        coins += value;
        coinDisplay.text = coins.ToString();
    }

}
