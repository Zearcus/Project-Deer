using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    public GameObject card;
    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    private void PickUp(GameObject game) { 
        if(game.name == "Deck"){
            CreateCards();
        }
    }

    private void CreateCards() 
    { 
        float posZ = 0.0f;
       // var Cards = Ressources.Load("Card") as GameObject;
        Instantiate(card, new Vector3(-191.4f, -325.9f,-261.3f + posZ), transform.rotation);

        posZ = posZ + 1.0f;
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
                    //GetNameObject(hit.transform.gameObject);
                    PickUp(hit.transform.gameObject);
                }
            }
        }
    }

    private void GetNameObject(GameObject game){
        Debug.Log(game.name);
    }
}
