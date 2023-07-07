using UnityEngine;

public class Pick : MonoBehaviour
{
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
            Instantiate(card, new Vector3(transform.position.x, transform.position.y, transform.position.z + posZ), transform.rotation);

            posZ = posZ + 1.0f;
        }
    }

}
