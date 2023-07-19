using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Pick pick;
    public CardSettings set;
    public ButtonSettings button;
    // public Mana mana;
    public MouseClickManager mouse;

    //public MouseClick click;
    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    private void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(mouse.Ray(), out mouse.hit, 100.0f))
            {
                if (mouse.hit.transform != null)
                {
                   pick.PickUp(mouse.hit.transform.gameObject);
                   //test(mouse.hit.transform.gameObject);
                   set.SetButtons(mouse.hit.transform.gameObject);
                   button.SetArea(mouse.hit.transform.gameObject);
                }
            }
        }
    }

    void test(GameObject game){
        Debug.Log(game.name);
    }
}