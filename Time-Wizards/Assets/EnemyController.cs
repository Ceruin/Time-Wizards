using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Enemy
{
    [SerializeField] float moveSpeed = 0.4f;

    Rigidbody enemyRigidBody;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == Tags.Player.ToString())
        {
            enemyRigidBody = collision.gameObject.GetComponent<Rigidbody>();
            if (enemyRigidBody != null)
            {
                enemyRigidBody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            }
        }
    }
}

public enum Tags {
    Player,
    Enemy,
}

