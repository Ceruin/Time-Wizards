using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EnemyController : Enemy
{
    float shrinkSizeAmount = 0.999f;
    int timeTillShrink = 10;
    Transform enemyTransform;

    Stopwatch timer = new Stopwatch();

    void Awake()
    {
        enemyTransform = GetComponent<Transform>();
        timer.Start();
    }

    void Update()
    {
        if (enemyTransform.localScale.x > 0.2)
        {
            if (timer.Elapsed.Milliseconds > timeTillShrink)
            {
                timer.Restart();
                enemyTransform.localScale = Vector3.Scale(enemyTransform.localScale, new Vector3(shrinkSizeAmount, shrinkSizeAmount, shrinkSizeAmount));
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}