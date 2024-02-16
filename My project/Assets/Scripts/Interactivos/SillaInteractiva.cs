using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillaInteractiva : ObjetoInteractuable
{
    public float mover = 0;
    public float devolver = 0;
    private bool posicion = false;

    public override void Activar() //esta es la accion real que se ejecuta cuando se interacta con la puerta
    {
        if (posicion)
        {
            transform.position = new Vector3(0, 0, devolver);
            accionNombre = "Mover silla";
        }

        else
        {
            transform.position = new Vector3(0, 0, mover);
            accionNombre = "Dejar silla";
        }

        posicion = !posicion;
    }
}

