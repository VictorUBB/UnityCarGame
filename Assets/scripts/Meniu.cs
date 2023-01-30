using UnityEngine.SceneManagement;
using UnityEngine;

public class Meniu : MonoBehaviour
{
    public GameObject niveleUI;
    public GameObject instructiuni;
   
    public void startmeniu ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void aratNivele ()
    {
        niveleUI.SetActive(true);
    }
    public void aratInstructiuni()
    {
        instructiuni.SetActive(true);
    }
    public void inapoi()
    {
        instructiuni.SetActive(false);
    }
    public void inapoi2()
    {
        niveleUI.SetActive(false);
    }

}
