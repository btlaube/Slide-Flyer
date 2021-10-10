using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] things;

    //public Transform firePoint;
    public float spawnRate = 2f;
    public float timeToSpawn = 2f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn) {
            Generate();
            timeToSpawn = Time.time + spawnRate;
        }
    }

    void Generate() {
        int rand = Random.Range(0, things.Length);
        Instantiate(things[rand], transform.position, Quaternion.identity, transform);
    }

    public void SetSpawnRate(float f) {
        spawnRate = f;
    }

    public void SetTimeToSpawn(float f) {
        timeToSpawn = f;
    }

}
