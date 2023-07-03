using UnityEngine;
using TMPro;

public class ChoiceEvent : MonoBehaviour, IClicked
{
    GameObject myCanvas;
    GameObject player;
    PlayerMovement _player;
    DialogueManager dialogue;
    public GameObject Narration;
    [SerializeField] private TextMeshProUGUI dialogueText;

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
        _player.enabled = true;
    }

    public void dialogCountinue()
    {
        if (Narration == enabled)
        {
            dialogue.dialog++;
            Debug.Log(dialogue.dialog);
        }
        else
        {
            Debug.Log("Not Active");
        }
    }

    public void onClickedButton()
    {
        if (gameObject.tag == "NarrationPoint")
        {
            _player.speed = 2f;
        }
    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "Player")
        {
            Narration.SetActive(true);
        }
    }
}
