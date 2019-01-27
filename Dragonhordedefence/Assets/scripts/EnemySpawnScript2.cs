using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript2 : MonoBehaviour
{
    public GameObject enemy;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 4f;
    float nextSpawn = 0.0f;
    public float randomRange1;
    public float randomRange2;
        

    public float DspawnRate = 0.05f;
    public float DspawnRateHigh = 10f;
    public float DspwanRateLow = 1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + Random.Range(DspwanRateLow + spawnRate, DspawnRateHigh + spawnRate);
            randY = Random.Range(randomRange1, randomRange2);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            
            if (spawnRate >= 0)
            {
            spawnRate = spawnRate - DspawnRate;
            }
        }
        
    }
}
