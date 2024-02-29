using System.Collections;
using System.Collections.Generic;
using TMPro;//PARA LA PUNTUACION DE LA UI
using UnityEngine;

public class detectordecolumnas : MonoBehaviour
{
    public TMP_Text textObject;//PARA LA PUNTACION DE LA UI
    public int puntuacion = 0;
    public int puntosPorColumna = 1;

    // Start is called before the first frame update
    void OnTriggerExit()
    {
        puntuacion = puntuacion + puntosPorColumna;
        textObject.GetComponentInChildren<TextMeshProUGUI>().SetText(puntuacion.ToString());

    }


}
