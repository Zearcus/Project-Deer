using UnityEngine;
using Ink.Runtime;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    private bool dialogueIsPlaying;
    private Story currentStory;
    private static DialogueManager instance;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one DialogueManager");
        }
        instance = this;    
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start() 
    {
        dialogueIsPlaying = false; 
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;

        if (currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
        }
        else
        {
            dialogueIsPlaying = false;
            dialogueText.text = "";
        }
    }
}
