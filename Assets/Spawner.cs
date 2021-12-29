using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour 
{
    public Transform [] spawnPoints;
    public GameObject[] hazards;
    private float timeBtwSpawns = 5;
    public float startTimeBtwSpawns;
    public float minTimBtwSpawns;
    public float decrease;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            if(timeBtwSpawns >= 0){
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomHazard = hazards[0];
                Instantiate(randomHazard, randomSpawnPoint, position, Quaternion.identity);

                if(startTimeBtwSpawns > minTimBtwSpawns){
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;
            }else{
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
