using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_04 : MonoBehaviour
{
    private void Start()
    {
        // Exercise 1
        Calculator(4, 2);

        // Exercise 2
        string inputLetter = "a";

        bool isVowel = IsVowel(inputLetter);

        Debug.Log($"{isVowel}");

        // Exercise 3
        int day = 3;
        int month = 8;
        int year = 2012;

        bool isValid = IsValidDate(day, month, year);

        Debug.Log($"{isValid}");

        // Exercise 4

        bool isLeap = IsLeapYear(year);

        Debug.Log($"{isLeap}");

        // Exercise 5
        day++;

        if (day > 31 || (month == 2 && day > 28) || ((month == 4 || month == 6 || month == 9 || month == 11) && day > 31))
        {
            day = 1;
            month++;

            if (month > 12)
            {
                month = 1;
                year++;
            }
        }

        Debug.Log($"{day}/{month}/{year}");

        // Exercise 6
        day--;

        if (day > 31 || (month == 2 && day > 28) || ((month == 4 || month == 6 || month == 9 || month == 11) && day > 31))
        {
            day = 1;
            month--;

            if (month > 12)
            {
                month = 1;
                year--;
            }
        }

        Debug.Log($"{day}/{month}/{year}");

        // Exercise 7
        string zodiac = GetChineseZodiac(year);

        Debug.Log($"{zodiac}");

        // Exercise 8
        float baseLength = 7f;
        float height = 9f;

        float area = CalculateTriangleArea(baseLength, height);

        if (area >= 0f)
        {
            Debug.Log($"{area}");
        }
        else
        {
            Debug.Log("Invalid");
        }

        // Exercise 9
        int grade = 78;

        string letterGrade = GetLetterGrade(grade);

        Debug.Log($"{letterGrade}");

        // Exercise 10
        {
            int number = 5;

            bool isEven = IsEven(number);

            Debug.Log($"{isEven}");
        }

    }

    // Exercise 1
    private void Calculator(float num1, float num2)
    {
        if (num1 < num2)
        {
            Debug.Log($"{num1}");
        }
        else
        {
            Debug.Log($"{num2}");
        }
    }

    // Exercise 2
    private bool IsVowel(string letter)
    {
        return "aeiou".Contains(letter);
    }

    // Exercise 3
    private bool IsValidDate(int day, int month, int year)
    {
        if (year < 0 || year > 2024)
            return false;

        if (month <= 1 || month >= 12)
            return false;

        if (day <= 1 || day > 31)
            return false;

        return true;
    }

    // Exercise 4
    private bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Exercise 7
    private string GetChineseZodiac(int year)
    {
        string[] zodiacs = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep" };

        int baseYear = 1924;
        int index = (year - baseYear) % 12;

        if (index < 0)
        {
            index += 12;
        }

        return zodiacs[index];
    }

    // Exercise 8
    static float CalculateTriangleArea(float baseLength, float height)
    {
        if (baseLength <= 0 || height <= 0)
        {
            return -1f;
        }

        float area = 0.5f * baseLength * height;
        return area;
    }

    // Exercise 9
    static string GetLetterGrade(int grade)
    {
        if (grade < 0 || grade > 100)
        {
            return "Invalid grade";
        }
        else if (grade < 50)
        {
            return "D";
        }
        else if (grade < 70)
        {
            return "C";
        }
        else if (grade < 90)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }

    // Exercise 10
    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
