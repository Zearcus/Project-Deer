using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Pick pick;
    public SetOnBoard set;

    public MouseClickManager mouse;

    //public MouseClick click;
    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    private void MouseClick()
    {
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(mouse.Ray(), out mouse.hit, 100.0f))
            {
                if (mouse.hit.transform != null)
                {
                   pick.PickUp(mouse.hit.transform.gameObject);
                   set.GetNameAndSet(mouse.hit.transform.gameObject);
                   //test(hit.transform.gameObject);
                }
            }
        }
    }

    void test(GameObject game){
        //Debug.Log(game.name);
    }
}

// public class MouseClick : MonoBehaviour{
//     public RaycastHit hit;
    
// }