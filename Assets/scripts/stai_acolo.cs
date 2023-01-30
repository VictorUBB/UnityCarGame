using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stai_drq_acolo : MonoBehaviour
{
    public Vector3 miscare1;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "player")
        {
            transform.position = miscare1;

        }
    }
}
