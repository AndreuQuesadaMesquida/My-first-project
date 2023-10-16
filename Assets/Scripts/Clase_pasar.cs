using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase_pasar : MonoBehaviour
{

    private bool monday = false;
    private bool tuesday = false;
    private bool wednesday = false;
    private bool thursday = true;
    private bool friday = false;
    private bool saturday = false;

    private int lives = 9;

    private int grade = 7;

    private void Start()
    {
        if (monday)
        {
            Debug.Log("Es lunes");
        }
        else if (tuesday)
        {
            Debug.Log("Es martes");
        }
        else if (wednesday)
        {
            Debug.Log("Es miercoles");
        }
        else if (thursday)
        {
            Debug.Log("Es jueves");
        }
        else if (friday)
        {
            Debug.Log("Es viernes");
        }
        else if (saturday)
        {
            Debug.Log("Es sabado");
        }
        else
        {
            Debug.Log("Es domingo");
        }

        // Tenemos 10 vidas en total
        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }
        else if (lives <= 1)
        {
            Debug.Log("Solo te queda una vida");
        }
        else if (lives <= 5)
        {
            Debug.Log("Ve con precaucion te quedan pocas vidas");
        }

        // Suspenso, Aprobado (>= 5), Notable bajo (=7), alto (=8) (>=7), Excelente (>=9)
        if (grade >= 9)
        {
            //Debug.Log("Excelente");
            if (grade == 10)
            {
                Debug.Log("Matricula de honor");
            }
            if (grade == 9)
            {
                Debug.Log("Excelente");
            }
        }
        else if (grade >= 7)
        {
            //Debug.Log("Notable");
            if (grade == 8)
            {
                Debug.Log("Notable alto");
            }
            else
            {
                Debug.Log("Notable bajo");
            }
        }
        else if (grade >= 5)
        {
            //Debug.Log("Aprobado");
            if (grade == 6)
            {
                Debug.Log("Aprobado alto");
            }
            if (grade == 5)
            {
                Debug.Log("Aprobado bajo");
            }
        }
    }
}


    


        



     
