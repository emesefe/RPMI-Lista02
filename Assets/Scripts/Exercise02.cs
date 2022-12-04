using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        if (year % 12 == 0)
        {
            Debug.Log("Monkey");
            
        }
        else if (year % 12 == 1)
        {
            Debug.Log("Rooster");
        }
        else if (year % 12 == 2)
        {
            Debug.Log("Dog");
        }
        else if (year % 12 == 3)
        {
            Debug.Log("Pig");
        }
        else if (year % 12 == 4)
        {
            Debug.Log("Rat"); 
        }
        else if (year % 12 == 5)
        {
            Debug.Log("Ox");   
        }
        else if (year % 12 == 6)
        {
            Debug.Log("Tiger");
        }
        else if (year % 12 == 7)
        {
            Debug.Log("Rabbit");
        }
        else if (year % 12 == 8)
        {
            Debug.Log("Dragon");
        }
        else if (year % 12 == 9)
        {
            Debug.Log("Snake");
        }
        else if (year % 12 == 10)
        {
            Debug.Log("Horse");
        }
        else // Se trata del último caso posible, que es year % 12 == 11
        {
            Debug.Log("Goat");
        }
    }
}
