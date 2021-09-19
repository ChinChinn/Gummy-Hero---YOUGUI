using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemy;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    public float minTimeBtwSpawns;
    public float decrease;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (timeBtwSpawns <= 0)
            {
                Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject randomEnemy = enemy[Random.Range(0, enemy.Length)];
                Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
                if (startTimeBtwSpawns > minTimeBtwSpawns)
                {
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;
            }else{
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
