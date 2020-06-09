using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform transformPOS;

    // Start is called before the first frame update
    void Awake()
    {
        transformPOS = GetComponent<Transform>();
    }
}
