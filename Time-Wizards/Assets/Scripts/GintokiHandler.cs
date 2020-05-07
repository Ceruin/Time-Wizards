using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GintokiHandler : MonoBehaviour
{
    // TODO:
    // FIGURE OUT WHY FIRE NO STAY WITH DAD
    
    [SerializeField] GameObject explodeFX;
    [SerializeField] Transform parent;
    float timeAlive = 0f;

    void Start()
    {
        timeAlive = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeAlive > 3)
        {
            GameObject fx = Instantiate(explodeFX, transform.position, Quaternion.identity);
            fx.transform.parent = parent;
            Destroy(gameObject);
        }
    }
}
