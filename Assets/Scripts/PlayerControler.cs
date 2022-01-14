using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;

    public float startDashTime;
    private float dashTime;

    public float extraSpeed;

    private bool isDashing;

    private float input;
    public int health;

    Rigidbody2D rb;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();
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
        
    }

    private void FixedUpdate() {
        input = Input.GetAxis("Horizontal");
        Debug.Log("Input =" + input);
        
        rb.velocity = new Vector2 (input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount){
        health -= damageAmount;

        if(health <= 0){
            
            Destroy(gameObject);
        }
    }
}

