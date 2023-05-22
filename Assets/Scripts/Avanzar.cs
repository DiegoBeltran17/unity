using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avanzar : MonoBehaviour
{
        public float distanciaARecorrer = 20.0f;
    public float velocidad = 5.0f;
    private AudioSource sonidoLlegada;
    public AudioClip llegadaAstronautas;
    private bool ejecutado = true;

    private float distanciaRecorrida = 0.0f;  
    // Start is called before the first frame update
    void Start()
    {
        sonidoLlegada = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;
        transform.Translate(Vector3.forward * movimiento);
        distanciaRecorrida += movimiento;
        if (distanciaRecorrida >= distanciaARecorrer && ejecutado) {
            velocidad = 0.0f;  
            sonidoLlegada.PlayOneShot(llegadaAstronautas, 0.5f);
            Debug.Log("hhohol");
            ejecutado = false;
            }
    }

}
