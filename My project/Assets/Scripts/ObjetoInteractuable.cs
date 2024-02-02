using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInteractuable : MonoBehaviour
{
    
    public string accionNombre;

    private void OnTriggerEnter(Collider other)
    {
        ConmtroladorUI.Instancia.MostrarInteractuable(this);
    }

    private void OnTriggerExit(Collider other)
    {
        ConmtroladorUI.Instancia.MostrarInteractuable(null);
    }
}
