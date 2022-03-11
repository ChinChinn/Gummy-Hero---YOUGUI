using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControler : MonoBehaviour
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

    public int Coin;

    Rigidbody2D rb;

    Animator anim;

    GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();

        healthDisplay.text = health.ToString();
        coinDisplay.text = Coin.ToString();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

   
    void Update()
    {
        if(input == 0){
            //Idle
            anim.SetBool("IsRunning" , false);
        }
        else{
            //El jugador se esta moviendo reproduce run
            anim.SetBool("IsRunning" , true);
            }

        if (input  > 0){
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else if(input < 0) {
            transform.eulerAngles = new Vector3(0,180,0);

        }

        if(Input.GetKeyDown(KeyCode.Space) && isDashing == false ){
            speed += extraSpeed;
            isDashing = true;
            dashTime=  startDashTime;

        }

        if(dashTime <= 0 && isDashing == true ){
            isDashing = false;
            speed -= extraSpeed;
        }else{
            dashTime -=Time.deltaTime;
        }
        //healthDisplay.text = health.ToString();
    }

    private void FixedUpdate() {
        input = Input.GetAxis("Horizontal");
       // Debug.Log("Input =" + input);
        
        rb.velocity = new Vector2 (input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount){
        health -= damageAmount;
        healthDisplay.text = health.ToString();
        if(health <= 0){
            healthDisplay.text = "0";
            gameManager.gameOver();
            Destroy(gameObject);

        }
    }

    public void addPoints(int pointsAmount){
        Coin += pointsAmount;
        coinDisplay.text = Coin.ToString();
    }
}

