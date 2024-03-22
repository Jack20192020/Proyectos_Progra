using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AsignadorDestinoNav : MonoBehaviour
{
    public GameObject destino;
    private NavMeshAgent navegadorIA;
    // Start is called before the first frame update
    void Start()
    {
        navegadorIA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(destino != null)
        {
            navegadorIA.destination = destino.transform.position;
        }
    }
}
