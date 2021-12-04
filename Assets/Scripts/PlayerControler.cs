using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;

    private float input;
    public int health;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
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

