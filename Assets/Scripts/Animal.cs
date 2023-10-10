using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int totalLegs = 4;
    [SerializeField] private string name;

    private bool HasMoreThanTwoLegs;

    private void Start()
    {
        

        HasMoreThanTwoLegs = totalLegs > 2;

        if ( HasMoreThanTwoLegs == true)
        { 
            Debug.Log($"{name} tiene {totalLegs} patas: {HasMoreThanTwoLegs}"); 
        }
            

    }

    

}

