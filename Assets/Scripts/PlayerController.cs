using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public int health;
    private float input;
    Rigidbody2D rb;
    Animator anim; 
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update() {
        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }else {
            anim.SetBool("isRunning", false);
        }

        if (input > 0 )
        {
            transform.eulerAngles = new Vector3(0,0,0);
        }else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    void FixedUpdate() {
        input = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }


    public void takeDamage(int damage){
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
