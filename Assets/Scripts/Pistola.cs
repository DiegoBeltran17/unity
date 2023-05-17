using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour
{
    [SerializeField] private float speed = 40;
    public GameObject bala;
    public Transform arma;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public OVRInput.Button shootButton;
    private OVRGrabbable grabbable;

    
    public void Disparar(){
        GameObject spawnBala = Instantiate(bala, arma.position, arma.rotation);
        spawnBala.GetComponent<Rigidbody>().velocity = speed * arma.forward;
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnBala, 2);
    }

    void Update(){
        if(grabbable.isGrabbed && OVRInput.GetDown(shootButton)){
            Disparar();
        }
    }

}
