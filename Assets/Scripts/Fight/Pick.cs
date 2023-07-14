using UnityEngine;

public class Pick : MonoBehaviour
{
    //Database data = new Database();
    InventoryTest test= new InventoryTest();
    float posZ;
    private bool canPick = true;

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
            // var Cards = Ressources.Load("Card") as GameObject;
            card = Instantiate(card, new Vector3(-2.2f, 0.1f, -0.7f + posZ), transform.rotation);
            card.name = test.GetNameDataBase();
            posZ = posZ + 2.0f;
        }
    }
}
