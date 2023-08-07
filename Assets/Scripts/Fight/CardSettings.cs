using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public GameObject Summon, Detail;
    private int CurrentValue;
    private Vector3 cardPos, range = new(0.2f, 0, -0.6f);
    //private string testString;

    //create a a collider area for set cards in the board
    public void SetButtons(GameObject game)
    {
        //testString = game.name;
        if (game.tag == "Cards")
        {
            cardPos = game.transform.position;
            if(CurrentValue != 0){
                DestroyButton();
            }
            CreateButton();
            
        }
    }

    private void CreateButton()
    {
        int MaxValue = 2;
        float PosX = 0.0f;
        for (int i = 0; i < MaxValue; i++)
        {
            CurrentValue++;
            switch (CurrentValue)
            {
                case 1:
                    GameObject buttonS = Instantiate(Summon, new Vector3(cardPos.x + range.x, cardPos.y, cardPos.z + range.z), Quaternion.Euler(90, 90, 0));
                    buttonS.name = "Button" + " " + SetNameButton();
                    buttonS.tag = "Button";
                    PosX -= 0.7f;
                    break;
                case 2:
                    GameObject buttonD = Instantiate(Detail, new Vector3(cardPos.x + range.x + PosX, cardPos.y, cardPos.z + range.z), Quaternion.Euler(90, 90, 0));
                    buttonD.name = "Button" + " " + SetNameButton();
                    buttonD.tag = "Button";
                    break;
                default:
                    Debug.Log("Rien ne peut être invoqué.");  
                    break;
            }
        }
    }

    public void DestroyButton()
    {
        for (int i = 0; i != CurrentValue;)
        {
            var name = GameObject.Find("Button" + " " + SetNameButton());
            Destroy(name);
            CurrentValue--;
        }
    }

    private string SetNameButton()
    {
        string name = "";
        switch (CurrentValue)
        {
            case 1:
                name = "Summon";
                break;
            case 2:
                name = "Detail";
                break;
            default:
                Debug.Log("Le Bouton que vous voulez créer ou supprimer n'existe pas.");
                break;
        }
        return name;
    }
}