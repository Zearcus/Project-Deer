using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public GameObject Collider, Button;
    private int MaxSpawnArea = 4, CurrentValue;
    private float PosZ;
    private char letter;
    private bool isActivate = false;

    //create a a collider area for set cards in the board
    public void AreaSetCards(GameObject game)
    {
        if (game.tag == "Cards")
        {
            CreateColliders();
            isActivate = true;

        }
        if (game.tag != "Cards" && isActivate == true)
        {
            DeleteColliders();
        }
    }

    private void CreateColliders()
    {
        // create colliders
        while (CurrentValue != MaxSpawnArea)
        {
            CurrentValue++;
            SetLetterColliderTag();
            GameObject Area = Instantiate(Collider, new Vector3(-0.5f, 0.3f, 2.0f + PosZ), transform.rotation);
            Area.name = "Collider";
            Area.tag = "Collider" + " " + letter;
            
            PosZ = PosZ - 1.0f;
        }
        if (CurrentValue == MaxSpawnArea)
        {
            PosZ = 0.0f;
        }
    }

    private void DeleteColliders()
    {
        while (CurrentValue != 0)
        {
            SetLetterColliderTag();
            var name = GameObject.FindGameObjectWithTag("Collider" + " " + letter);
            Destroy(name);
            CurrentValue--;
        }
    }

    private void SetLetterColliderTag()
    {
        switch (CurrentValue)
        {
            case 1:
                letter = 'A';
                break;
            case 2:
                letter = 'B';
                break;
            case 3:
                letter = 'C';
                break;
            case 4:
                letter = 'D';
                break;
        }
    }
}