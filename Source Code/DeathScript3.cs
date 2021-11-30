using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript3 : MonoBehaviour
{
    public AudioClip deathSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = deathSound;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle" || collision.gameObject.tag == "Building")
        {
            audioSource.Play();
            RubyTextScript.amount = 0;
            Application.LoadLevel("Easy");
        }


    }
}
