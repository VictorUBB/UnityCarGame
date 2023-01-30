using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart_Button : MonoBehaviour
{
   public  void Reincepe ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
