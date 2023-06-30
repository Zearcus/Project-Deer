using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    float posZ;
    
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
        // var Cards = Ressources.Load("Card") as GameObject;
        Instantiate(card, new Vector3(transform.position.x, transform.position.y, transform.position.z + posZ), transform.rotation);

        posZ = posZ + 1.0f;
    }
    //click the cards for show area collider and place the cards
    private void SetCards(){}
    //create a a collider area for set cards in the board
    private void AreaSetCards(){}
}
