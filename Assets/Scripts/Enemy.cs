using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float minspeed;
    public float maxSpeed;


    float speed;

    public int damage;

    public GameObject explosion;
    public GameObject explosion2;

    PlayerControler  playerScript;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minspeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            print("We HIT the Jugador");
            playerScript.TakeDamage(damage);
            Instantiate(explosion2, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
        if(other.tag == "Ground"){
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
