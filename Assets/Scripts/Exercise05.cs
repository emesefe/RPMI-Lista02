using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise05 : MonoBehaviour
{
    public int age;

    private void Start()
    {
        if (age >= 18)
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age");
        }
        else
        {
            Debug.Log($"Hello, you are {age} years old, so you are NOT of legal age");
        }
        
    }
}
