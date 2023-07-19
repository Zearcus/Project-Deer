using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public GameObject Button;
    private int CurrentValue;
    //private string testString;

    //create a a collider area for set cards in the board
    public void SetButtons(GameObject game)
    {
        //testString = game.name;
        if (game.name == "Card")
        {
            CreateButton();
        }
        if (game.name != "Card")
        {
            DestroyButton();
        }
    }

    private void CreateButton()
    {
        int MaxValue = 2;
        float PosX = 0.0f;
        while (CurrentValue != MaxValue)
        {
            CurrentValue++;
            GameObject button = Instantiate(Button, new Vector3(-2.0f + PosX, 0.1f, -1.3f), Quaternion.Euler(90, 90, 0));
            button.name = "Button" + " " + SetLetterButton();
            button.tag = ("Button");
            PosX = PosX - 0.5f;

        }
    }

    private void DestroyButton()
    {
        while (CurrentValue != 0)
        {
            var name = GameObject.Find("Button" + " " + SetLetterButton());
            Destroy(name);
            CurrentValue--;
        }
    }

    private char SetLetterButton()
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
            default:
                Debug.Log("Le Bouton que vous voulez créer ou supprimer n'exisste pas.");
                break;
        }
        return letter;
    }
}