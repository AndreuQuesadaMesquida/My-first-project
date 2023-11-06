using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_04 : MonoBehaviour
{
    // Exercise 1
    private float num1 = 3;
    private float num2 = 2;

    // Exercise 2
    private bool a = false;
    private bool e = true;
    private bool i = false;
    private bool o = false;
    private bool u = false;

    // Exercise 3
    private int day = 4;
    private int month = 13;
    private int year = 2034;

    private void Start()
    {
        // Exercise 1
        if (num1 < num2)
        {
            Debug.Log($"{num1}");
        }
        else
        {
            Debug.Log($"{num2}");
        }

        // Exercise 2
        if (a || e || i || o || u)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }

        // Exercise 3
        if (year < 2024 || month <= 1 || month >= 12 || day <= 1 || day >= 31)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }



    }
}
