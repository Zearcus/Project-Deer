using UnityEditor.ShaderGraph;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public bool playerInRange;

    [SerializeField]
    GameObject toDestroy;

    private void Awake() 
    {
        toDestroy = this.gameObject;
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

    public void DestroyComp()
    {
        Destroy(toDestroy.gameObject.GetComponent<ChoiceEvent>());
    }
}
