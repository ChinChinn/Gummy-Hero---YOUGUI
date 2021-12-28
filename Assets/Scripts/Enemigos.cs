using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public float MinSpeed;
    public float MaxSpeed;

    float Speed;
    public int damage;
    public GameObject explosion;

    PlayerController playerScript;


    // Start is called before the first frame update
    void Start()
    {
        
        Speed = Random.Range(MinSpeed, MaxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            print("We HIT the Jugador");
            playerScript.TakeDamage(damage);
        }
    
    }

}
