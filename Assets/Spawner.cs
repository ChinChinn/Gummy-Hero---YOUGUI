using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour 
{
    public Transform [] spawnPoints;
    public GameObject[] hazards;
    private float timeBtwSpawns = 5;
    public float startTimeBtwSpawns;
    public float decrease;
    public GameObject player;
}
public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            if(timeBtwSpawns >= 0){
                Transform randomSpawnPoint = spawnPoints[random.Range(0, spawnPoints.Length)];
            }
        }
    }
}
