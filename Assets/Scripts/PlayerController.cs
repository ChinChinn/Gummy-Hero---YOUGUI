using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; 
    private float input;

    public int health; 
    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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
    }

    private void FixedUpdate() {
        input = Input.GetAxis("Horizontal");
        Debug.Log(input);
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount){
        health -= damageAmount;

        if (health <= 0){
            Destroy(gameObject);
        }
    }

}
