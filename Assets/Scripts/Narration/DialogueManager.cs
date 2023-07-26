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
    [SerializeField] public int part, dialog, choice;
    [SerializeField] GameObject Narration, player;
    [SerializeField] PlayerMovement _player;
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
        dialog = 1;
        choice = 0;
        textSpeed = 0.02f;
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
        text = data.Narration["part" + part + " dialog" + dialog + " choice" + choice].CoreText;
        nameText.text = data.Narration["part" + part + " dialog" + dialog + " choice" + choice].NameCharacter;
        _narrationObject.sprite = Resources.Load<Sprite>(data.Narration["part" + part + " dialog" + dialog + " choice" + choice].Picture);
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
        text = data.Narration["part" + part + " dialog" + dialog + " choice" + choice].CoreText;
        nameText.text = data.Narration["part" + part + " dialog" + dialog + " choice" + choice].NameCharacter;
        _narrationObject.sprite = Resources.Load<Sprite>(data.Narration["part" + part + " dialog" + dialog + " choice" + choice].Picture);

        if (dialog >= 5 && dialog <= 5)
        {
            Narration.SetActive(false);
            Debug.Log("Change de scene");
            _player.canMove = true;
        }
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
