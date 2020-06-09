using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float secondTillSpawn = 1;
    [SerializeField] int spawnSizeMultiplier = 1;
    [SerializeField] int spawnCap = 50;
    [SerializeField] int cubesToSpawn = 1;
    [SerializeField] float minForceToCube = 10;
    [SerializeField] float maxForceToCube = 50;
    [SerializeField] int spawnRange = 10;
    [SerializeField] GameObject enemyCube;

    Stopwatch timer = new Stopwatch();

    private void Start()
    {
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {     
        if (timer.Elapsed.Seconds > secondTillSpawn)
        {
            timer.Restart();
            if (spawnCap > 0)
            {
                for (int i = 0; i < cubesToSpawn; i++)
                {
                    SpawnCube();
                }
            }
        }
    }

    private void SpawnCube()
    {
        GameObject gameObject = Instantiate(enemyCube.gameObject, 
            new Vector3(
            Random.Range(transform.position.x - spawnRange, transform.position.x + spawnRange),
            Random.Range(transform.position.y, transform.position.y + spawnRange),
            Random.Range(transform.position.z - spawnRange, transform.position.z + spawnRange)),           
            Quaternion.identity);
        spawnCap--;

        gameObject.transform.localScale = gameObject.transform.localScale * spawnSizeMultiplier;

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * Random.Range(minForceToCube, maxForceToCube), ForceMode.Impulse);
    }
}
