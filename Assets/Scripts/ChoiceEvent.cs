using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceEvent : MonoBehaviour, IClicked
{
    GameObject myCanvas;
    GameObject player;
    PlayerMovement _player;
    public GameObject Narration;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    int index;

    private void Awake() 
    {
        myCanvas = GameObject.FindWithTag("Canvas");
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
        index = 0;
    }

    public void onClickedEvent()
    {
        foreach (Transform element in GameObject.FindWithTag("Canvas").transform)
        {           
            Narration.SetActive(true);
        }
    }

    public void onClickedButton()
    {
        if (gameObject.tag == "NarrationPoint")
        {
            _player.speed = 2f;
        }
    }
}
