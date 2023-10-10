using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    [SerializeField] private float num;

    [SerializeField] private int edad;

    [SerializeField] private float dinero = 20.5f;
    [SerializeField] private float price = 100f;


    private void Start()
    {
        
        if (num % 2 == 0)
        {
            Debug.Log($"{num} es par");
        }
        else
        {
            Debug.Log($"{num} es impar");
        }

        if (edad >= 18)
        {
            Debug.Log("es mayor de edad");
        }
        else
        {
            Debug.Log("es menor de edad");
        }

        if (dinero >= price)
        {
            Debug.Log("Aqui tienes");
        }
        else
        {
            Debug.Log("Otra vez será");
        }
       


    }

}
