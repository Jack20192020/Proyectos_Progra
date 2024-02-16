using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject areaDestino;
    public GameObject areaActual;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Desactivo objetos actuales para eviar bcomportamientos no deseados
            areaActual.SetActive(false);
            GameObject player = other.gameObject;
            other.gameObject.SetActive(false);

            //creo el area a donde me voy a mover
            GameObject areaNueva = Instantiate(areaDestino);
            areaNueva.transform.position = Vector3.zero;

            //destruyo el area, porque bya no la necesito
            Destroy(areaActual);

            //obtengo el punto donde debe aparecer el player
            PuntoSpawn punto = GameObject.FindAnyObjectByType<PuntoSpawn>();

            //coloco ahi al play6er y loo reactico
            player.transform.position = punto.transform.position;
            player.SetActive(true);



        }
    }
}
