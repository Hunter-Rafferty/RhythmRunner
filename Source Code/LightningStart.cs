using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningStart : MonoBehaviour
{
    public GameObject lightningBolt;
    AudioSource audioManager;
    public AudioClip lightningStrike;

    private void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            lightningBolt.SetActive(true);
            audioManager.clip = lightningStrike;
            audioManager.Play();
            Invoke("LightningBoltEnd", 0.25f);
        }
    }

    void LightningBoltEnd()
    {
        lightningBolt.SetActive(false);
    }
}
