using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour
{
    public float tiempoParaDesaparecer = 15.0f; // Tiempo en segundos antes de desaparecer el objeto

    private float tiempoTranscurrido = 0.0f; // Tiempo transcurrido desde que se inició el script

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime; // Actualizar el tiempo transcurrido

        // Si ha pasado el tiempo especificado, desactivar el objeto para hacerlo desaparecer de la escena
        if (tiempoTranscurrido >= tiempoParaDesaparecer)
        {
            gameObject.SetActive(false); // Desactivar el objeto para hacerlo desaparecer de la escena
        }
    }
}
