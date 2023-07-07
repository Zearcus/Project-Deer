using UnityEngine;

public class EnableMove : MonoBehaviour, IClicked
{
    GameObject myCanvas;
    GameObject player, dialogueManager;
    PlayerMovement _player;
    DialogueManager _dialogueManager;

    int index;

    private void Awake() 
    {
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
    }

    public void onClickedEvent()
    {   
        _player.canMove = true;
        _player.enabled = true;
    }

    public void onClickedButton()
    {
        if (gameObject.tag == "TriggerZone")
        {
            _player.speed = 2f;
        }
    }
}
