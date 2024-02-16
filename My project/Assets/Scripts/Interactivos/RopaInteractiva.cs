using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopaInteractiva : ObjetoInteractuable
{
    public GameObject ropa;
    public override void Activar()
    {
        if (ropa.gameObject.activeInHierarchy)
        {
            ropa.gameObject.SetActive(false);
            accionNombre = "Tomar ropa";
        }

        else
        {
            ropa.gameObject.SetActive(true);
            accionNombre = "Dejar ropa";
        }

    }
}

