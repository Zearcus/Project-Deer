using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    public void OpenPause()
    {
        Menu.SetActive(true);
    }
}
