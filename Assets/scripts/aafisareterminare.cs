using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aafisareterminare : MonoBehaviour
{
    public sefi controleaza;

    void OnTriggerEnter()
       {
        controleaza.completelevel();
       }
}
