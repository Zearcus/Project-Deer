using UnityEngine;
using TMPro;

public class EnableCanvas : MonoBehaviour
{
    GameObject player;
    PlayerMovement _player;
    GameObject myCanvas;
    DialogueManager dialogue;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] GameObject Narration;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
        myCanvas = GameObject.FindWithTag("Canvas");
    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "Player")
        {
            Narration.SetActive(true);
            _player.canMove = false;
            DialogueManager.GetInstance().EnterNarrationMode();
        }
    }
}
