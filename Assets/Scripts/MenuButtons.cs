using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuButtons : MonoBehaviour
{

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

    public void CharacterSelected()
    {
        SceneManager.LoadScene("Map");
    }

    public void ExitInventory()
    {
        foreach (Transform element in GameObject.Find("InventoryUI").transform)
        {
            element.gameObject.SetActive(false);
        }
    }

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

    public void QuitSettings()
    {
        foreach (Transform element in GameObject.Find("Settings").transform)
        {
            element.gameObject.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        gameObject.SetActive(false);
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

    public void Settings()
    {
        foreach (Transform element in GameObject.Find("Settings").transform)
        {
            element.gameObject.SetActive(true);
        }
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
