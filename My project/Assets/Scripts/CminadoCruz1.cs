using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Leo los bvalores de los ejes horizontal y verti9cal en input y guardo cada uno en una variable
// Mando el valor de cada eje a los bparam,etros correspondientes delo animator
public class CminadoCruz1 : MonoBehaviour
{
    private Rigidbody cam;
    public float movi;

    void Start()
    {
        cam = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        Vector3 direc = (transform.forward * verti + transform.right * horiz).normalized;
        cam.velocity = direc * movi;
    }
}
