using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

   
    void Start()
    {

    }

    void Update ()
    {

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;

            FindObjectOfType<sefi>().PunePauza();
        }  
	}
}
