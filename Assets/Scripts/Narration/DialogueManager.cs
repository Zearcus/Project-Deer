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
    [SerializeField] int part, dialog;
    string text;
    string name;
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

    private void Update() 
    {
        text = data.Narration["part" + part + " dialog" + dialog].CoreText;
        name = data.Narration["part" + part + " dialog" + dialog].NameCharacter;

        if (dialogueText.text == null || nameText.text == null)
        {
            dialogueText.text = text;
            nameText.text = name;
        }
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    void Start() 
    {
        part = 1;
        dialog = 0;
        textSpeed = 0.02f;
    }

    public void EnterNarrationMode()
    {
        StopAllCoroutines();
        StartCoroutine(ProgressiveText());
        Debug.Log(dialog);
        Debug.Log(dialogueText.text);
        Debug.Log(nameText.text);
    }

    public void NextDialogue()
    {
        dialog++;
        dialogueText.text = text;
        nameText.text = name;
    }

    public void NextPart()
    {
        part++;
    }

    IEnumerator ProgressiveText()
    {
        dialogueText.text = text;
        foreach (char c in text.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public IEnumerator EndText()
    {
        StopAllCoroutines();
        dialogueText.text = text;
        yield return null;
    }
}
