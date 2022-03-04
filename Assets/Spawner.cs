using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{   
    public Transform[] spawnPoints;

    public GameObject[] hazards;

    private float timeBtwSpawns;

    public float startTimeBtwSpawns;

    public float minTimeBtwSpawns;

    public float decrease;

    public GameObject player;

    public GameManager gameManager;
    // Update is called once per frame

    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    void Update()
    {
        if(player != null && gameManager.getGameStatus()){
                 if (timeBtwSpawns <= 0) {
                    Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                    GameObject randomHazard = hazards[0];
                    Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);
                     if(startTimeBtwSpawns > minTimeBtwSpawns){
                            startTimeBtwSpawns -= decrease;
                        }
                     timeBtwSpawns = startTimeBtwSpawns;
        }       else{
                    timeBtwSpawns -= Time.deltaTime;
                }

        }
    

    }
}
