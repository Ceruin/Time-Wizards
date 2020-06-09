using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyController : Enemy
{
    [SerializeField] int timeTillDeath = 2;
    Transform enemyTransform;

    Stopwatch timer = new Stopwatch();

    void Awake()
    {
        enemyTransform = GetComponent<Transform>();
        timer.Start();
    }

    void Update()
    {
            if (timer.Elapsed.Seconds > timeTillDeath)
            {
                timer.Stop();
                Destroy(gameObject);
            }
    }
}