using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cilindru : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Destroy(this.gameObject);
            Time.timeScale = 1;
        }
    }

}
