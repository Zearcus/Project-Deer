using UnityEngine;
using Ink.Runtime;

public class DialogueManager : MonoBehaviour
{
    private static DialogueManager instance;

    private void Awake() 
    {
        instance = this;    
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }
}
