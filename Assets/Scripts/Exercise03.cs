using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    public int num;

    private void Start()
    {
        if (num % 5 == 0)
        {
            Debug.Log($"{num} is divisible by 5");
        }
        else
        {
            Debug.Log($"{num} isn't divisible by 5");
        }
    }
}
