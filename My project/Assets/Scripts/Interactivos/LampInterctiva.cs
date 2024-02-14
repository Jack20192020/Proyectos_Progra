using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampInterctiva : ObjetoInteractuable
{
    public Light laluz;
    public override void Activar()
    {
        if (laluz.gameObject.activeInHierarchy)
        {
            laluz.gameObject.SetActive(false);
            accionNombre = "Encender luz";
        }

        else
        {
            laluz.gameObject.SetActive(true);
            accionNombre = "Apagarluz";
        }
        
    }
}
