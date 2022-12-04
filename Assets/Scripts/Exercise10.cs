using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Exercise10 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log($"{year} is a leap year.");
                }
                else
                {
                    Debug.Log($"{year} is not a leap year.");
                }
            }
            else
            {
                Debug.Log($"{year} is a leap year.");
            }
        }
        else
        {
            Debug.Log($"{year} is not a leap year.");
        }
    }
}
