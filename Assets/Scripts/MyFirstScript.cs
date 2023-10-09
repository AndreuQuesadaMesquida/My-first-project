using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /* 
    Comentario linea 1
    Comentario linea 2
    Comentario linea 3
    */

    // Serializefield es privado pero se puede sobrescribir en el inspector pero no en otros scripts

    // Variable que representa la eded de un jugador
    [SerializeField] private int age = 18; // = 0;
    // Variable que representa la velocidad
    [SerializeField] private float speed = 1.5f; // =0.0f;
    // Variable que representa si el jugador esta vivo o muerto
    [SerializeField] private bool isGameOver = false; // = false;
    // Variable que representa el nombre del jugador
    [SerializeField] private string username = "Pepito"; // = "";

    [SerializeField] private float num1 = 2;
    [SerializeField] private float num2 = 6;

    [SerializeField] private int coins;

    private float result;

    [SerializeField] private int hour;

    private void Start()
    {
        /*
        Debug.Log("Hola, mundo!");
        Debug.Log(username);
        Debug.Log(age);
        Debug.Log(speed);
        Debug.Log(isGameOver);

        // Forma 1
        Debug.Log($"El nombre de usuario es: {username}");

        // Forma 2
        Debug.Log(string.Format("La velocidad del usuario es {0} m/s", speed));
        Debug.Log(string.Format("El usuario {0} va a {1} m/s", username, speed));

        // Forma 3
        Debug.Log("El ususario tiene " + age + " años.");
        */

        /*
        Debug.Log(2 + 5);
        Debug.Log(num1 + num2);
        Debug.Log(num1 + 10);

        Debug.Log($"Monedas: {coins}");
        // coins = coins + 10;
        coins += 10;
        Debug.Log($"Monedas: {coins}");
        */

        /*
        Debug.Log($"{num1} + {num2} = {num1 + num2}");


        // +=
        coins = coins + 5;
        coins += 5;
        */

        // Debug.Log(hour % 12);

    }
}
    