using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_03 : MonoBehaviour
{
    // Exercise 1
    private int num1 = 4;
    private int num2 = 7;

    // Exercise 2
    private bool a = false;
    private bool e = false;
    private bool i = false;
    private bool o = false;
    private bool u = false;

    // Exercise 3
    

    private void Start()
    {
        // Exercise 1
        if (num1 > num2)
        {
            Debug.Log($"{num1}");
        }
        else
        {
            Debug.Log($"{num2}");
        }

        // Exercise 2
        if (a)
        {
            Debug.Log("vowel");
        }
        else if (e)
        {
            Debug.Log("vowel");
        }
        else if (i)
        {
            Debug.Log("vowel");
        }
        else if (o)
        {
            Debug.Log("vowel");
        }
        else if (u)
        {
            Debug.Log("vowel");
        }
        else
        {
            Debug.Log("consonant");
        }


    }

}
