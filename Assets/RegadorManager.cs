using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RegadorManager : MonoBehaviour
{
    public Action<float> alRegar;
    public float totalTimeToRegar = 5;
    float actualRegar = 0;
    public static RegadorManager instance;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            alRegar?.Invoke(0.7f);
        }
    }
}
