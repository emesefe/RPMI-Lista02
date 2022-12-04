using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise07 : MonoBehaviour
{
    public string operation;
    public float x;
    public float y;

    private void Start()
    {
        if (operation == "sum")
        {
            Debug.Log($"{x} + {y} = {x + y}");
        }
        else if (operation == "subtraction")
        {
            Debug.Log($"{x} - {y} = {x - y}");
        }
        else if (operation == "product")
        {
            Debug.Log($"{x} x {y} = {x * y}");
        }
        else if (operation == "division")
        {
            Debug.Log($"{x} : {y} = {x / y}");
        }
    }
}
