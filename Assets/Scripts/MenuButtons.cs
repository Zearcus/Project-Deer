using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuButtons : MonoBehaviour
{
    public void Play()
    {
        foreach (Transform element in GameObject.Find("Setup 2").transform)
        {
            element.gameObject.SetActive(false);
        }
        foreach (Transform element in GameObject.Find("SaveMenu").transform)
        {
            element.gameObject.SetActive(true);
        }
    }

    public void BackSave()
    {
        foreach (Transform element in GameObject.Find("Setup 2").transform)
        {
            element.gameObject.SetActive(true);
        }
        foreach (Transform element in GameObject.Find("SaveMenu").transform)
        {
            element.gameObject.SetActive(false);
        }
    }

    public void SaveSelected()
    {
        foreach (Transform element in GameObject.Find("CharacterSelection").transform)
        {
            element.gameObject.SetActive(true);
        }
        foreach (Transform element in GameObject.Find("SaveMenu").transform)
        {
            element.gameObject.SetActive(false);
        }
    }

    public void BackCharacter()
    {
        foreach (Transform element in GameObject.Find("CharacterSelection").transform)
        {
            element.gameObject.SetActive(false);
        }
        foreach (Transform element in GameObject.Find("SaveMenu").transform)
        {
            element.gameObject.SetActive(true);
        }
    }

    public void Settings()
    {
        foreach (Transform element in GameObject.Find("Settings").transform)
        {
            element.gameObject.SetActive(true);
        }
    }

    public void QuitSettings()
    {
        foreach (Transform element in GameObject.Find("Settings").transform)
        {
            element.gameObject.SetActive(false);
        }
    }
}
