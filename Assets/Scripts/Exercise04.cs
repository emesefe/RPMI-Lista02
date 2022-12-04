using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise04 : MonoBehaviour
{
    public float triangleBase;
    public float triangleHeight;

    private void Start()
    {
        if (triangleBase > 0 && triangleHeight > 0)
        {
            Debug.Log($"The area of the triangle is {triangleBase * triangleHeight / 2}");
        }
        else
        {
            Debug.Log("The area cannot be calculated");
        }
    }
}
