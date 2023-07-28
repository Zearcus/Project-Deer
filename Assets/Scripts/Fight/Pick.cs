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
            card = Instantiate(card, new Vector3(-2.7f, 0.1f, -0.7f + posZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
            card.name = test.GetNameDataBase();
            card.tag = "Cards";
            posZ = posZ + 2.0f;
        }
    }
}

public class Inventory{
    string name;
}
