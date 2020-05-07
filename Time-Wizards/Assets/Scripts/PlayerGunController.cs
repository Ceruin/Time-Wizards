using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : MonoBehaviour
{
    [SerializeField] GameObject cannonBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire"))
        {
            GameObject newBall = Instantiate(cannonBall, transform.position, Quaternion.identity);
            Rigidbody test = newBall.gameObject.GetComponentInChildren<Rigidbody>();

            test.AddExplosionForce(1000, Vector3.up, 100);
        }
    }
}
