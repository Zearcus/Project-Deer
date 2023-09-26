using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextDialogue : MonoBehaviour
{

    [SerializeField] DialogueManager _dialogueManager;
    
    private void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "Player")
        {
            _dialogueManager.dialog++;
        }
    }
}
