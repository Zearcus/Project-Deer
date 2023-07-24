using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public GameObject Summon, Detail;
    private int CurrentValue;
    private bool isActivate = false;
    //private string testString;

    //create a a collider area for set cards in the board
    public void SetButtons(GameObject game)
    {
        //testString = game.name;
        if (game.name == "Card")
        {
            CreateButton();
            isActivate = true;
        }
        if ( game.name != "Card" && isActivate == true)
        {
            DestroyButton();
            isActivate = false;
        }
    }

    private void CreateButton()
    {
        int MaxValue = 2;
        float PosX = 0.0f;
        while (CurrentValue != MaxValue)
        {
            CurrentValue++;
            switch (CurrentValue)
            {
                case 1:
                    GameObject buttonS = Instantiate(Summon, new Vector3(-2.5f + PosX, 0.1f, -1.3f), Quaternion.Euler(90, 90, 0));
                    buttonS.name = "Button" + " " + SetNameButton();
                    buttonS.tag = ("Button");
                    PosX = PosX - 0.7f;
                    break;
                case 2:
                    GameObject buttonD = Instantiate(Detail, new Vector3(-2.5f + PosX, 0.1f, -1.3f), Quaternion.Euler(90, 90, 0));
                    buttonD.name = "Button" + " " + SetNameButton();
                    buttonD.tag = ("Button");
                    //PosX = PosX - 0.5f;
                    break;
                default:
                    Debug.Log("Rien ne peut être invoqué.");
                    break;
            }
        }
    }

    private void DestroyButton()
    {
        while (CurrentValue != 0)
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