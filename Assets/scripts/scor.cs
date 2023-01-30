using UnityEngine.UI;
using UnityEngine;

public class scor : MonoBehaviour
{
    public Transform player;
    public Text textscor;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textscor.text = player.position.z.ToString("0");
    }
}
