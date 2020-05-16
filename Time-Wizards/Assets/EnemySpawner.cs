using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float secondTillSpawn = 1;
    [SerializeField] int spawnCap = 50;
    [SerializeField] GameObject enemyCube;

    // Update is called once per frame
    void Update()
    {
        secondTillSpawn -= Time.deltaTime;
        if (secondTillSpawn <= 0)
        {
            secondTillSpawn = 1;
            if (spawnCap > 0)
            {
                GameObject gameObject = Instantiate(enemyCube.gameObject, transform.position, Quaternion.identity);
                Rigidbody rb = gameObject.GetComponent<Rigidbody>();
                rb.AddForce(Vector3.up * Random.Range(10f, 50f), ForceMode.Impulse);
                spawnCap--;
            }
        }
    }
}
