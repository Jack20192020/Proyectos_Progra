using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminarSimple : MonoBehaviour
{
    private Rigidbody cuerpo;
    private Animator miAnimador;
    public float velocidadMovi;

    void Start()
    {
       cuerpo = GetComponent<Rigidbody>();
       miAnimador = GetComponent<Animator>();
    }
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        if (horiz != 0 || verti != 0)
        {
            Vector3 direc = (transform.forward * verti + transform.right * horiz).normalized;
            cuerpo.velocity = direc * velocidadMovi;
            miAnimador.SetBool("Correr", true);
        }
        else
        {
            cuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("Correr", false);
        }
    }
}
