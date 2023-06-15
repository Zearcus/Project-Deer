using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceEvent : MonoBehaviour, IClicked
{
    GameObject myCanvas;
    public GameObject Narration;
    int index;

    private void Awake() 
    {
        myCanvas = GameObject.FindWithTag("Canvas");
        index = 0;
    }

    public void onClickedEvent()
    {
        foreach (Transform element in GameObject.FindWithTag("Canvas").transform)
        {           
            Narration.SetActive(true);
        }
    }
}
