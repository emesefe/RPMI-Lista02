using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public float num;

    private void Start()
    {
        // Se podría hacer en otro orden
        // La clave está en usar un if, else if y else
        if (num > 0)
        {
            Debug.Log($"{num} is positive");
        }else if (num == 0)
        {
            Debug.Log($"{num} is zero");
        }
        else
        {
            Debug.Log($"{num} is negative");
        }
    }
}
