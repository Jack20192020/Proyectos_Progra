using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavadoraInteractuable : ObjetoInteractuable
{
    private EfectoSonoros lavadora;
    private bool apagado = true;

    private void Start()
    {
        lavadora = GetComponent<EfectoSonoros>();
    }
    public override void Activar() 
    {
        if (apagado)
        {
            apagado = false;
            lavadora.reproducir("encendida");
            accionNombre = "Apagar lavadora";
        }

        else
        {
            apagado = true;
            accionNombre = "Encender lavadora";
            lavadora.detener("apagada");
        }
            
    }
}
