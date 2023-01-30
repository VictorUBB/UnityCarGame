using UnityEngine.SceneManagement;
using UnityEngine;

public class sefi : MonoBehaviour
{ public float timp = 2f;
    bool ok = false;
    public GameObject terminareUI;
    public GameObject pauzaUI;
    public void completelevel ()
    {
        terminareUI.SetActive(true);
    }

    public void EndGame ()
    {   if(ok==false)
        {
            ok = true;
            
            Invoke("Restart", timp);
        }
        
    }

   public void PunePauza ()
    {
        pauzaUI.SetActive(true);

    }


    public void OprestePauza ()
    {
        pauzaUI.SetActive(false);
        
        Time.timeScale = 1f;
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
