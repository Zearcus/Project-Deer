using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceEvent : MonoBehaviour, IClicked
{
    GameObject myCanvas;

    private void Awake() 
    {
        myCanvas = GameObject.FindWithTag("Canvas");
    }

    public void onClickedEvent()
    {
        foreach (Transform element in GameObject.FindWithTag("Canvas").transform)
        {
            element.gameObject.SetActive(true);
        }
    }
}
