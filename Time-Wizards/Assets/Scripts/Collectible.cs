using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    [SerializeField] int Time = 0;

    // Start is called before the first frame update
    void Start()
    {
        TimerController test = FindObjectOfType<TimerController>();
        test.AddTime(Time);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
