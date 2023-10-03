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
    private float speed = 1.5f; // =0.0f;
    // Variable que representa si el jugador esta vivo o muerto
    private bool isGameOver = false; // = false;
    // Variable que representa el nombre del jugador
    private string username = "Pepito"; // = "";
}
    