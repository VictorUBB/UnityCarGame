using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public Vector3 startPosision;
	// Use this for initialization
	void Start () {
        //setez poz initiala
        transform.position = startPosision;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
