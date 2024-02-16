using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoSpawn : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "PuntoSpawn");
    }
}
