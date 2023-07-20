using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] Image _narrationObject;
    [SerializeField] Sprite narBG;
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
        Debug.Log(text);
        Debug.Log(name);
        Debug.Log(_narrationObject.sprite);
    }

    public void NextDialogue()
    {
        dialog++;
        text = data.Narration["part" + part + " dialog" + dialog].CoreText;
        nameText.text = data.Narration["part" + part + " dialog" + dialog].NameCharacter;
        _narrationObject.sprite = Resources.Load<Sprite>(data.Narration["part" + part + " dialog" + dialog].Picture);
    }

    public void NextPart()
    {
        part++;
    }

    IEnumerator ProgressiveText()
    {
        dialogueText.text = "";
        foreach (char c in text.ToCharArray())
        {
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public IEnumerator EndText()
    {
        StopAllCoroutines();
        yield return dialogueText.text = text;
    }
}
