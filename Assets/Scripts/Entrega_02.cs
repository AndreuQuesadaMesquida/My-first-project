using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Entrega_02 : MonoBehaviour
{
    // Exercise 1:

    [SerializeField] private int num1;
    [SerializeField] private int num2;

    // Exercise 4:

    // Pendiente

    // Exercise 5:

    [SerializeField] private string username = "Andreu";

    // Exercise 2:

    private void Start()
    {
        Debug.Log($"{num1} + {num2} = {num1 + num2}");

        // Exercise 3:

        if (num1 >= num2)
        {
            Debug.Log($"{num1} is greater than or equal to {num2}");
        }
        else
        {
            Debug.Log($"{num1} is lower than {num2}");
        }

        // Exercise 6:

        Debug.Log($"Welcome {username}");

    }







}
