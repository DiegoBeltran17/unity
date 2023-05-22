using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detener : MonoBehaviour
{
    public float tiempoParaDesaparecer = 10.0f; // Tiempo en segundos antes de desaparecer el objeto

    private Animator animator; // Referencia al componente Animator del objeto
    private float tiempoTranscurrido = 0.0f; // Tiempo transcurrido desde que se inició la animación

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>(); // Obtener la referencia al componente Animator del objeto
        //animator.Play("ExpAnimator"); // Iniciar la animación
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime; // Actualizar el tiempo transcurrido

        // Si ha pasado el tiempo especificado, detener la animación y desaparecer el objeto
        if (tiempoTranscurrido >= tiempoParaDesaparecer)
        {
            animator.enabled = false; // Deshabilitar el componente Animator para detener la animación
             gameObject.SetActive(false); // Desactivar el objeto para hacerlo desaparecer de la escena
        }
    }
}
