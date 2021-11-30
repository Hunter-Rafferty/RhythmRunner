using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLightning : MonoBehaviour
{
    AudioSource mainMusic;
    AudioSource AudioManager;
    public AudioClip gameOver;
    bool deathCheck = false;
    public GameObject deathScreen1;
    public GameObject deathScreen2;
    public GameObject deathScreen3;
    public GameObject deathScreen4;

    private void Start()
    {
        mainMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "LightningCollision")
        {
            deathCheck = true;
            mainMusic.Stop();

            AudioManager = GameObject.Find("AudioManager").GetComponent<AudioSource>();
            AudioManager.clip = gameOver;
            AudioManager.Play();

            Time.timeScale = 0.0f;
            StartCoroutine(DeathScreen());
        }
    }

    private IEnumerator DeathScreen()
    {
        deathScreen1.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        deathScreen2.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        deathScreen3.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        deathScreen4.SetActive(true);
    }
}
