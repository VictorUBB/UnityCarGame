
using UnityEngine;

public class lovitura : MonoBehaviour
{   public Vector3 miscare1;
    public micare move;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "perete")
        {
            move.enabled = false;
            FindObjectOfType<sefi>().EndGame();

        }
    }
}
