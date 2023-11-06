using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_03 : MonoBehaviour
{
    // Exercise 1
    private float num1 = 4f;
    private float num2 = 7f;

    // Exercise 2
    private bool a = false;
    private bool e = true;
    private bool i = false;
    private bool o = false;
    private bool u = false;

    // Exercise 3
    [SerializeField] private int num3 = 9;
    [SerializeField] private int num4 = 3;

    // Exercise 4
    [SerializeField] private string grade = "B";

    // Exercise 5
    private int day = 14;
    private int month = 4;
    private int year = 2036;

    // Exercise 6 XD

    // Exercise 7
    private string horoscope = "";

    // Exercise 8
    private bool monday = false;
    private bool tuesday = false;
    private bool wednesday = false;
    private bool thursday = false;
    private bool friday = false;

    // Exercise 9
    private int age = 20;
    private string rank = "bronze";

    // Exercise 10
    private int angle1 = 60;
    private int angle2 = 60;
    private int angle3 = 60;

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

        // Exercise 3
        if (num3 % num4 == 0)
        {
            Debug.Log ($"{num3} is divisible by {num4}");
        }
        else
        {
            Debug.Log ($"{num3} is not divisible by {num4}");
        }

        // Exercise 4
        if (grade == "A")
        {
            Debug.Log("excellent");
        }
        else if (grade == "B")
        {
            Debug.Log("notable");
        }
        else if (grade == "C")
        {
            Debug.Log("passed");
        }
        else
        {
            Debug.Log("fail");
        }

        // Exercise 5
        if (year < 2024 && month >= 1 && month <= 12 && day >= 1 && day <= 31)
        {
            Debug.Log("Is a valid date");
        }
        else
        {
            Debug.Log("Is not a vailid date");
        }

        /*
        Exercise 6
        XD
        */
         


        // Exercise 7
        if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
        {
           Debug.Log (horoscope = "Aquarius");
        }
        else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
        {
            Debug.Log (horoscope = "Pisces");
        }
        else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
        {
            Debug.Log (horoscope = "Aries");
        }
        else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
        {
            Debug.Log (horoscope = "Taurus");
        }
        else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
        {
            Debug.Log (horoscope = "Gemini");
        }
        else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
        {
            Debug.Log (horoscope = "Cancer");
        }
        else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
        {
            Debug.Log (horoscope = "Leo");
        }
        else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
        {
            Debug.Log (horoscope = "Virgo");
        }
        else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
        {
            Debug.Log (horoscope = "Libra");
        }
        else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
        {
            Debug.Log (horoscope = "Scorpio");
        }
        else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
        {
            Debug.Log (horoscope = "Sagittarius");
        }
        else
            Debug.Log (horoscope = "Capricorn");

        // Exercise 8
        if (monday || tuesday || wednesday || thursday || friday)
        {
            Debug.Log("Not weekend :(");
        }
        else
        {
            Debug.Log("It's weekend :)");
        }

        // Exercise 9
        if (age >= 65)
        {
            if (rank == "gold")
            {
                Debug.Log ("75%");
            }
            else if (rank == "silver")
            {
                Debug.Log ("50%");
            }
            else if (rank == "bronze")
            {
                Debug.Log ("25%");
            }
        }
        else if (age < 65 && age > 18)
        {
            if (rank == "gold")
            {
                Debug.Log ("50%");
            }
            else if (rank == "silver")
            {
                Debug.Log ("25%");
            }
            else if (rank == "bronze")
            {
                Debug.Log ("15%");
            }
        }
        else
        {
            Debug.Log("No discount");
        }

        // Exercise 10
        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log ("They can be");
        }
        else
        {
            Debug.Log ("They cannot be");
        }

    }

}
