using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControladorMenuOpciones : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMix;
    public void pantallaCompleta (bool pCompleta)
    {
        Screen.fullScreen = pCompleta;
    }

    public void CambiarVol(float volumen) 
    {
        audioMix.SetFloat("Volumen", volumen);
    }

    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
