using UnityEngine;
using TMPro;

public class EnableMove : MonoBehaviour, IClicked
{
    GameObject myCanvas;
    GameObject player;
    PlayerMovement _player;

    int index;

    private void Awake() 
    {
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
    }

    public void onClickedEvent()
    {
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
