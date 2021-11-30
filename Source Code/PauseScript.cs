using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    bool GamePaused = false;
    public GameObject pauseScreen;
    AudioSource mainMusic;
    // Update is called once per frame

    private void Start()
    {
        mainMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1.0f;
        mainMusic.UnPause();
    }

    public void Pause()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
        mainMusic.Pause();
    }
}
