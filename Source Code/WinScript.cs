using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{

    AudioSource mainMusic;
    public GameObject winscreen1;
    public GameObject winscreen2;
    public GameObject winscreen3;
    public GameObject winscreen4;

    private void Start()
    {
        mainMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            mainMusic.Stop();
            StartCoroutine(WinScreen());
            Time.timeScale = 0.0f;
            
        }
    }
    private IEnumerator WinScreen()
    {
        winscreen1.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        winscreen2.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        winscreen3.SetActive(true);
        yield return new WaitForSecondsRealtime(0.05f);
        winscreen4.SetActive(true);
    }


}
