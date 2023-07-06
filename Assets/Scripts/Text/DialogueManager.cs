using UnityEngine;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    private bool dialogueIsPlaying;
    Database data = new Database();
    private static DialogueManager instance;
    CursorController controls;
    public int part, dialog;

    private void Awake() 
    {
        controls = new CursorController();
        if (instance != null)
        {
            Debug.LogWarning("Found more than one DialogueManager");
        }
        instance = this;    
    }

    private void Update() 
    {

    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start() 
    {
        part = 1;
        dialog = 1;
        dialogueText.text = data.Dialogue["part" + part + " dialog" + dialog];
    }

    public void EnterDialogueMode()
    {
        StartCoroutine(ProgressiveDisplay());
        
    }

    IEnumerator ProgressiveDisplay()
    {
        dialogueText.ForceMeshUpdate();

        int totalVisibleCharacters = dialogueText.textInfo.characterCount;
        int counter = 0;
        int visibleCount = 0;

        while (true)
        {
            visibleCount = counter % (totalVisibleCharacters + 1);

            dialogueText.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacters)
            {
                dialogueText.text = data.Dialogue["part" + part + " dialog" + dialog];
                
            }

            counter += 1;
            
            yield return new WaitForSeconds(0.05f);  
        }
    }

    IEnumerator Test()
    {
        foreach (char c in dialogueText.text)
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
