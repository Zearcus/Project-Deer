using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class EnableCanvas : MonoBehaviour
{
    GameObject player;
    PlayerMovement _player;
    GameObject myCanvas;
    DialogueManager dialogue;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] GameObject Narration;
    [SerializeField] Image _narrationObject;
    [SerializeField] float textSpeed;

    public DialogueObject currentDialogue;
    public int point;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        _player = player.GetComponent<PlayerMovement>();
        myCanvas = GameObject.FindWithTag("Canvas");
    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "Player")
        {
            Narration.SetActive(true);
            _player.canMove = false;
            DisplayDialogue(currentDialogue);
        }
    }
    
    private IEnumerator NextDialogue(DialogueObject dialogueObject)
    {
        dialogueText.ForceMeshUpdate();

        bool displaying = true;
        bool progressing = true;
    
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++)
        {
            nameText.text = dialogueObject.dialogueLines[i].name;
            dialogueText.text = dialogueObject.dialogueLines[i].dialogue;
            _narrationObject.sprite = dialogueObject.dialogueLines[i].narBG;

            dialogueText.text = "";

            foreach(char c in dialogueObject.dialogueLines[i].dialogue.ToCharArray())
            {
                if (progressing)
                {
                    dialogueText.text += c;
                    yield return new WaitForSeconds(textSpeed);

                    if(dialogueText.text.Length == dialogueObject.dialogueLines[i].dialogue.Length)
                    {
                        progressing = false;
                        displaying = false;
                    }
                }

                if (Input.GetMouseButton(0) && displaying)
                {
                    dialogueText.text = "";
                    displaying = false;
                    progressing = false;
                    Debug.Log("Debug 1 =" + displaying);
                }   
            }

            if (!displaying)
            {
                yield return new WaitUntil(()=>Input.GetMouseButtonDown(0));
                yield return null;
                displaying = true;
                progressing = true;
                Debug.Log("Debug 2 =" + displaying);
            }
        }
        
        Narration.SetActive(false);
        _player.canMove = true;
        point++;
        StopAllCoroutines();
    }

    public void DisplayDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(NextDialogue(dialogueObject));
    }
}
