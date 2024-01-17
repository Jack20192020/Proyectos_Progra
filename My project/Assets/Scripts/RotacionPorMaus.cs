using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPorMaus : MonoBehaviour
{
    public float velocidadRot = 1;

    // Update is called once per frame
    void Update()
    {
        //leo el movimieto del mouse yt luego roto el objeto sobre su eje y, en relaciona si mismo, no al mundo
        //self si mismo
        //world sobre le mundo
        float rotHoriz = Input.GetAxis("Mouse X");
        transform.Rotate(transform.up * rotHoriz * velocidadRot, Space.Self);
    }
}
