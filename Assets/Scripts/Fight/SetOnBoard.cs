using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOnBoard : MonoBehaviour
{
    
    LoadCards load;
    public GameObject Area;
    private string CheckTypeCards;

    private int MaxSpawnArea = 0, CurrentValue = 0;
    private float PosZ;

    //create a a collider area for set cards in the board
    public void AreaSetCards(GameObject game)
    {
        load = GameObject.Find("Card").GetComponent<LoadCards>();
        if (game.tag == "Cards")
        {
            if (load.textType.text == "Weapon")
            {
                CheckTypeCards = load.textType.text;
                SetTypeForColliders();
                CreateColliders();
            }
        }
    }

    private void SetTypeForColliders()
    {
        // Check the type if the card and set the number of spawning colliders with cards types
        switch (CheckTypeCards)
        {
            case "Weapon":
                MaxSpawnArea = 1;
                break;
            case "Spell":
                MaxSpawnArea = 2;
                break;
            case "Utilitie":
                MaxSpawnArea = 3;
                break;
        }
    }

    private void CreateColliders()
    {
        // create colliders
        while (CurrentValue != MaxSpawnArea)
        {
            Area = Instantiate(Area, new Vector3(-1.5f, 0.3f, 3.0f + PosZ), transform.rotation);
            Area.name = CheckTypeCards;
            Area.tag = "Weapon";
            CurrentValue++;
            PosZ = PosZ - 1.0f;
        }
        if (CurrentValue == MaxSpawnArea)
        {
            PosZ = 0.0f;
        }
    }
}