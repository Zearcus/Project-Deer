using UnityEngine;

public class Pick : MonoBehaviour
{
    //Database data = new Database();
    InventoryTest test = new InventoryTest();
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
            card = Instantiate(card, new Vector3(transform.position.x, transform.position.y, transform.position.z + posZ), transform.rotation);
            card.name = test.GetNameDataBase();
            posZ = posZ + 1.0f;
        }
    }
}
