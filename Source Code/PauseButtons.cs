using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MainMenu()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel("MusicTherapy_MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
