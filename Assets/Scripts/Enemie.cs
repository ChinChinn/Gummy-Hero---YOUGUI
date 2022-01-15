using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    float speed; 
    public int damage;
    public GameObject explosion; 
    PlayerController playerScript;
    void Start()
    {
        speed =  Random.Range(minSpeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            print("We HIT the Jugador");
            playerScript.TakeDamage(damage);
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if(other.tag == "Ground"){
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

}
