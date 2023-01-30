using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class micare : MonoBehaviour {
    public Rigidbody rb;
    public float Fortafata =2000f;
    public float fortalateral = 200f;
    public micare move;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        rb.AddForce(0, 0, Fortafata * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(fortalateral * Time.deltaTime, 0, 0,ForceMode.VelocityChange);


        }
         if(Input.GetKey("a"))
        {
            rb.AddForce(-fortalateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if(rb.position.y < 5f)
        {
            FindObjectOfType<sefi>().EndGame();
        }

         if(rb.position.x < -20f)
            {
            move.enabled = false;
            FindObjectOfType<sefi>().EndGame();
            }
        if (rb.position.x > -7f)
        {
            move.enabled = false;
            FindObjectOfType<sefi>().EndGame();
        }
    }
}
