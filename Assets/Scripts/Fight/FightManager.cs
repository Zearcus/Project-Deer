using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Pick pick = new Pick();
    public SetOnBoard set = new SetOnBoard();
    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    private void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                   pick.PickUp(hit.transform.gameObject);
                   set.GetNameAndSet(hit.transform.gameObject);
                   //test(hit.transform.gameObject);
                }
            }
        }
    }

    void test(GameObject game){
        Debug.Log(game.name);
    }
}
