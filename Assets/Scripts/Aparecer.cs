using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    public float retraso = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("Activar",retraso);
    }
void Activar(){
    gameObject.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
