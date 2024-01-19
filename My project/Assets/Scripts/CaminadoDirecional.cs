using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoDirecional : MonoBehaviour
{
    private Rigidbody cuerpo;
    private Animator miAnimador;
    public float velocidadMovi;
    public float velocidad = 10;

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

        /*Vector3 direc = (transform.forward * verti + transform.right * horiz).normalized;
        cuerpo.velocity = direc * velocidadMovi;  */

        Vector3 direccion = new Vector3(horiz, 0, verti);

        transform.forward = direccion;

        cuerpo.velocity = transform.forward * velocidad * direccion.magnitude;

        miAnimador.SetBool("CAMINANDO", direccion.magnitude < 0);


    }
}