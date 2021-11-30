using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{

    public GameObject startScreen;
    AudioSource mainMusicAudio;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0.0f;
        mainMusicAudio = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(startScreen.activeSelf == true)
        {
            if (Input.anyKeyDown)
            {
                startScreen.SetActive(false);
                Time.timeScale = 1.0f;
                mainMusicAudio.Play();

            }
        }
        
    }
}
