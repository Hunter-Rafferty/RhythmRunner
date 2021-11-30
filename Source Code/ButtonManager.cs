using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject levelSelect;
    public GameObject controls;
    public GameObject mainMenu;
    public GameObject pauseScreen;

    public void LevelSelect()
    {
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void Controls()
    {
        mainMenu.SetActive(false);
        controls.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void BacktoStart()
    {
        controls.SetActive(false);
        levelSelect.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void Level1()
    {
        Application.LoadLevel("Easy");
    }

    public void Level2()
    {
        Application.LoadLevel("Medium");
    }

    public void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

}
