using UnityEngine.SceneManagement;
using UnityEngine;

public class continua : MonoBehaviour
{
   
    public void continuare ()
    {
        FindObjectOfType<sefi>().OprestePauza();

    }

    

}
