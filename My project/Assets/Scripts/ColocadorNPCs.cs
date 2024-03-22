using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocadorNPCs : MonoBehaviour
{
    private GameObject[] puntoSpawn;
    private int indicePunto = 0;

    // Start is called before the first frame update
    private void Awake()
    {

        puntoSpawn = GameObject.FindGameObjectsWithTag("Spawn");
    }

    private void OnDrawGizmos()
    {
        if(puntoSpawn != null)
           {
            return;
        }

        foreach (GameObject punto in puntoSpawn)
        {
            Gizmos.DrawIcon(punto.transform.position, "Spawn");
        }
    }

    public void AlCrearNPC(GameObject generador, GameObject npc)
    {
        print("Se generò NPC" + npc.name);
        GameObject punto = puntoSpawn[indicePunto];
        npc.transform.position = punto.transform.position;

        indicePunto = (indicePunto + 1) % puntoSpawn.Length;

        AsignadorDestinoNav asignador = npc.GetComponent < AsignadorDestinoNav > ();
        asignador.destino = this.gameObject;


    }
}
