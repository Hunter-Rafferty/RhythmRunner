using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginningScreenScript : MonoBehaviour
{
    public GameObject whiteScreen1;
    public GameObject whiteScreen2;
    public GameObject whiteScreen3;
    public GameObject whiteScreen4;

    void Start()
    {
        StartCoroutine(BeginningScreen());
    }

    private IEnumerator BeginningScreen()
    {
        whiteScreen1.SetActive(false);
        yield return new WaitForSecondsRealtime(0.05f);
        whiteScreen2.SetActive(false);
        yield return new WaitForSecondsRealtime(0.05f);
        whiteScreen3.SetActive(false);
        yield return new WaitForSecondsRealtime(0.05f);
        whiteScreen4.SetActive(false);

    }
}
