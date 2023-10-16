using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_03 : MonoBehaviour
{

    private int num1 = 4;
    private int num2 = 7;

    private bool a = false;
    private bool e = false;
    private bool i = false;
    private bool o = false;
    private bool u = false;

    private void Start()
    {
        
        if (num1 > num2)
        {
            Debug.Log($"{num1}");
        }
        else
        {
            Debug.Log($"{num2}");
        }

        if (a)
        {
            Debug.Log("vowel");
        }

    }

}
