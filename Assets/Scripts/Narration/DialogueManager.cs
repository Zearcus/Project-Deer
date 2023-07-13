using UnityEngine;
using System.Collections;
using TMPro;
using Unity.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI nameText;
    private bool dialogueIsPlaying;
    Database data = new Database();
    private static DialogueManager instance; 
    public int part, dialog;
    string text;
    int numChar;
    [SerializeField] float textSpeed;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one DialogueManager");
        }
        instance = this;    
    }

    private void FixedUpdate() 
    {
        text = data.Dialogue["part" + part + " dialog" + dialog];
        DialogueBetweenCharacter();
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start() 
    {
        part = 1;
        dialog = 1;
        textSpeed = 0.02f;
        dialogueText.text = text;
    }

    public void EnterNarrationMode()
    {
        StopAllCoroutines();
        StartCoroutine(Test());
    }

    public void NextDialogue()
    {
        dialog++;
    }

    public void NextPart()
    {
        part++;
    }

    public void DialogueBetweenCharacter()
    {
        name = data.NameCharacters["name" + numChar];
        if (dialogueIsPlaying)
        {
            nameText.text = name;
        }
    }

    IEnumerator Test()
    {
        dialogueText.text = "";
        foreach (char c in text.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
