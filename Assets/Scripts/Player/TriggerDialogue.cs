using UnityEditor.ShaderGraph;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public bool playerInRange;

    private void Awake() 
    {
        playerInRange = false;
    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider col) 
    {
        if (col.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
