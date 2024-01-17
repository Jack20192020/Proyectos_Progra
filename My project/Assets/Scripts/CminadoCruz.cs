using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Leo los bvalores de los ejes horizontal y verti9cal en input y guardo cada uno en una variable
// Mando el valor de cada eje a los bparam,etros correspondientes delo animator
public class CminadoCruz : MonoBehaviour
{
    private Rigidbody cuerpo;
    private Animator miAnimador;
    public float velocidadMovi;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        miAnimador.SetFloat("MOV_LATERAL", horiz);
        miAnimador.SetFloat("MOV_FRONTAL", verti);

        Vector3 direc = (transform.forward * verti + transform.right * horiz).normalized;
        cuerpo.velocity = direc * velocidadMovi;


    }
}
