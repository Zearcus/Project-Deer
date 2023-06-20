using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField, Tooltip("Main Cursor")]
    public Texture2D cursor;
    [SerializeField, Tooltip("Clicked Cursor")]
    public Texture2D cursorClicked;
    
    private CursorControls controls;
    private Camera mainCamera;
    GameObject trigger;
    TriggerDialogue _trigger;
    ChoiceEvent choiceEvent;
    
    private void Awake() 
    {
        controls = new CursorControls();
        ChangeCursor(cursor);
        Cursor.lockState = CursorLockMode.Confined;
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable() 
    {
        controls.Disable();
    }

    private void Start() 
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
    }

    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }

    private void EndedClick()
    {
        ChangeCursor(cursor);
        DetectObject();
    }

    public void DetectObject()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                IClicked click = hit.collider.gameObject.GetComponent<IClicked>();
                trigger = hit.collider.gameObject;
                _trigger = trigger.GetComponent<TriggerDialogue>();

                if (hit.collider.tag == "TriggerZone" && this._trigger.playerInRange == true)
                {
                    if (click != null)
                    {
                        click.onClickedEvent();
                    }
                }

                if (hit.collider.tag == "Buttons")
                {
                    click.onClickedButton();
                }
                //Debug.Log("3D Hit:" + hit.collider.tag);
            }
        }
    }

    private void ChangeCursor(Texture2D cursorType)
    {
        //Vector2 hotspot = new Vector2(cursorType.width / 2, cursorType.height /2);
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }
}
