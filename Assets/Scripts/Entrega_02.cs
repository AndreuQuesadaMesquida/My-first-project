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

    // pendiente

    // Exercise 5:

    [SerializeField] private string username = "Andreu";

    // Exercise 7:

    [SerializeField] private int var1;
    [SerializeField] private int var2;

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

        // Exercise 8:

        Debug.Log($"{var1} % {var2} = {var1 % var2}");

    }

    // Exercise 9:

    // pendiente

    //Exercise 10:

    /*
    Exercise 1: The creation of the private variables num1 with number 2 and num2 with number 3 assigned to them in the inspector
    Exercise 2: The result displayed in the cosnole by the sum of the two variables is 5
    Exercise 3: The first variable created (num1) isn't greater than or equal to the second one (num 2) but instead is lower
    Exercise 4: 
    Exercise 5: The creation of a private string named "Andreu"
    Exercise 6: The message "Welcome Andreu" is displayed in the console
    Exercise 7: The creation of the private variables var1 with number 14 and var2 with number 6 assigned to them in the inspector
    Exercise 8: The result of the variable modulo displayed in the console is 2     ¿?*
    Exercise 9: 
    */





}
