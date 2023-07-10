using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOnBoard : MonoBehaviour
{
    private GameObject card, colliderCard;
    private string nameCard, nameCollider;
    // Update is called once per frame
    void Update()
    {
        
    }
    //click the cards for show area collider and place the cards
    private void SetCards() { }
    //create a a collider area for set cards in the board
    private void AreaSetCards() { }

    public void GetNameAndSet(GameObject game) {
        if(game.name == "Collider"){
            nameCard = game.name;
            
        }
        if(game.tag == "Clone"){
            nameCollider = game.tag;
            
        }

        if(nameCollider == "Collider" && nameCard == "Clone")
        {
            
        }
    }
}
