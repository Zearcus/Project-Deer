using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public GameObject Collider, Button;
    private int CurrentValue;
    //private float PosZ;
   // private char letter;
    private bool isActivate = false;

    //create a a collider area for set cards in the board
    public void AreaSetCards(GameObject game)
    {
        if (game.tag == "Cards")
        {
            //CreateButton(0);
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
        int MaxValue = 4;
        float PosZ = 0.0f;
        // create colliders
        while (CurrentValue != MaxValue)
        {
            CurrentValue++;
            GameObject Area = Instantiate(Collider, new Vector3(-0.5f, 0.3f, 2.0f + PosZ), transform.rotation);
            Area.name = "Collider";
            Area.tag = "Collider" + " " + SetLetterColliderTag();
            
            PosZ = PosZ - 1.0f;
        }
        if (CurrentValue == MaxValue)
        {
            PosZ = 0.0f;
        }
    }

    private void DeleteColliders()
    {
        while (CurrentValue != 0)
        {
            var name = GameObject.FindGameObjectWithTag("Collider" + " " + SetLetterColliderTag());
            Destroy(name);
            CurrentValue--;
        }
    }

    private void CreateButton(int Value)
    {
        int  MaxValue = 2;
        float PosX = 0.0f;
        while(Value != MaxValue)
        {
            Value++;
            GameObject Createbutton = Instantiate(Button, new Vector3(-2.0f + PosX, 0.1f, -1.3f), Quaternion.Euler(90,90,0));
            Createbutton.name = "Button";
            PosX = PosX - 0.5f;
        }
    }

    private char SetLetterColliderTag()
    {
        char letter = ' ';
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
            default:
                Debug.Log("Le Collider que vous voulez créer n'existe pas.");
                break;
        }

        return letter;
    }
}