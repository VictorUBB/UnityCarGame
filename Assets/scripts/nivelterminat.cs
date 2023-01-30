using UnityEngine.SceneManagement;
using UnityEngine;

public class nivelterminat : MonoBehaviour
{
  public void LoadNextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
