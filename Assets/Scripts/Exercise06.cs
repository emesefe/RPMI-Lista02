using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise06 : MonoBehaviour
{
    public float traveledDistance;
    public float totalDistance;

    private void Start()
    {
        if (traveledDistance >= totalDistance)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");
        }
        else
        {
            Debug.Log($"Oh... You still have {totalDistance - traveledDistance} meters left to complete the total distance.");
        }
    }
}
