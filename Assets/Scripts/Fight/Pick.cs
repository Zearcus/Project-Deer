using UnityEngine;
using System.Collections.Generic;
public class Pick : MonoBehaviour
{
    //Database data = new Database();
    InventoryTest inventory= new InventoryTest();

    float posZ;
   // public int ID;
    private bool canPick = true;
    public int MaxNumberInHand;
    public GameObject card;

    public void PickUp(GameObject game)
    {
        if (game.name == "Deck")
        {
            CreateCards();
        }
    }

    public void CreateCards()
    {
       
        if (canPick == true)
        {
            int ID = inventory.ID;
            // var Cards = Ressources.Load("Card") as GameObject;
            card = Instantiate(card, new Vector3(-2.7f, 0.1f, -0.7f + posZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
            card.name = inventory.random[ID];
            card.tag = "Cards";
            posZ += 1.5f;
            MaxNumberInHand++;
            inventory.ID++;
        }
    }
    
}