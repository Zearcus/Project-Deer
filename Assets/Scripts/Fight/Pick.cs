using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    float posZ = 0.0f;
    
    public GameObject card;
    // Update is called once per frame
    void Update()
    {
        //MouseClick();
    }

    public void PickUp(GameObject game)
    {
        if (game.name == "Deck")
        {
            CreateCards();
        }
    }

    public void CreateCards()
    {
        // var Cards = Ressources.Load("Card") as GameObject;
        Instantiate(card, new Vector3(transform.position.x, transform.position.y, transform.position.z + posZ), transform.rotation);

        posZ = posZ + 1.0f;
    }

    public void GetNameObject(GameObject game)
    {
        Debug.Log(game.name);
    }

    // private void MouseClick()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         RaycastHit hit;
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //         if (Physics.Raycast(ray, out hit, 100.0f))
    //         {
    //             if (hit.transform != null)
    //             {
    //                //pick.GetNameObject(hit.transform.gameObject);
    //                PickUp(hit.transform.gameObject);
    //             }
    //         }
    //     }
    // }
}
