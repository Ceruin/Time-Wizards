using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetSensitivity : MonoBehaviour
{
    Slider test;
    MouseLook test2;

    private void Start()
    {
        test = GetComponent<Slider>();
        test2 = FindObjectOfType<MouseLook>();
    }

    void Update()
    {
        test2.mouseSens = test.value;
    }
}
