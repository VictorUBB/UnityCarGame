using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("tasta a apasata");

        }
        //arata tasta pe care o apesi 
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log("TASTA SPACE");
            }
	}
}
