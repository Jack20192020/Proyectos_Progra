using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaInteracAnim : ObjetoInteractuable
{
    private Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    public override void Activar()
    {
        miAnimador.SetTrigger("ABRIR");
    }
}
