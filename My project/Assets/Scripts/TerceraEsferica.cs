using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerceraEsferica : MonoBehaviour
{
    public float velocidadRotacion = 1;
    public Transform pivote;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotMausX = Input.GetAxis("Mouse X");
        pivote.Rotate(Vector3.up * rotMausX);

        float rotMausY = Input.GetAxis("Mouse Y");
        pivote.Rotate(pivote.right * rotMausY, Space.World);

    }
}