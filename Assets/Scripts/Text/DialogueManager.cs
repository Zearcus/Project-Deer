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
    CursorController controls;
    public int part, dialog;
    string text;
    [SerializeField] float textSpeed;

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
        text = data.Dialogue["part" + part + " dialog" + dialog];
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

    public void EnterDialogueMode()
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
