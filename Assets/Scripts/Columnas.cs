using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columnas : MonoBehaviour
{
    public float velocidad = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(new Vector3(velocidad,0,0*Time.deltaTime
      ));  
    }
}
