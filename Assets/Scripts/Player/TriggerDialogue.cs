using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    private bool playerInRange;

    private void Awake() 
    {
        playerInRange = false;
    }

    private void OnTriggerEnter(Collider col) 
    {
        
    }

    private void OnTriggerExit(Collider col) 
    {
        
    }
}
