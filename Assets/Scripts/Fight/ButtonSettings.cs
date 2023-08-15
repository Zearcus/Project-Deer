using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    //readonly Pick pick;

    public GameObject Collider;
    private int CurrentValue;
    float PosZ = 0.0f;
    public bool Validate = true;
    private string nameC;
    private Vector3 colliderC, card;

    public void SetArea(GameObject game)
    {
        if (game.name == "Button Summon")
        {
            if (CurrentValue != 0)
            {
                DestroyColliders();
            }
            CreateColliders();
        }

        switch (game.tag)
        {
            case "Cards":
                nameC = game.name;
                card = game.transform.position;
                break;
            case "Collider":
                colliderC = game.transform.position;
                Summoning();
                break;
        }

    }
    //faire une liste pour enregistrer le nom des cartes que tu cliques pour pouvoir, 
    // tester et générers des colliders si il y a déjà des cartes sur le terrain.

    private void CreateColliders()
    {
        int MaxValue = 4;
        
        // create colliders
        for (int i = 0; i < MaxValue; i++)
        {
            CurrentValue++;
            //Debug.Log(CheckCollider());
            if(CheckCollider() == true){
                GameObject Area = Instantiate(Collider, new Vector3(-0.5f, 0.3f, 2.0f + PosZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
                Area.name = "Collider" + " " + SetLetterCollider();
                Area.tag = "Collider";
            }
            PosZ --;
        }
        PosZ = default;
    }

    private void DestroyColliders()
    {
        for (int i = 0; i != CurrentValue;)
        {
            var name = GameObject.Find("Collider" + " " + SetLetterCollider());
            Destroy(name);
            CurrentValue--;
        }
    }

    private char SetLetterCollider()
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
                Debug.Log("Le Collider que vous voulez créer ou supprimer n'existe pas.");
                break;
        }

        return letter;
    }

    public void Summoning()
    {
        float speed = 1.0f;
        GameObject move = GameObject.Find(nameC);
        while (move.transform.position != colliderC)
        {
            move.transform.position = Vector3.MoveTowards(move.transform.position, colliderC, speed);
        }
        DestroyColliders();
        Validate = !Validate;
    }

    private bool CheckCollider()
    {
        //Find script Pick in FightManagerGameObject
        GameObject pick = GameObject.Find("FightManager");

        // List and tab GameObject for found all Cards in scene       
        GameObject[] Cards = GameObject.FindGameObjectsWithTag("Cards");
        List<float> checkCard = new();
        List<string> NameCards = new();


        foreach(GameObject card in Cards){
            NameCards.Add(card.name);
        }
        for(int i = 0; i < pick.GetComponent<Pick>().MaxNumberInHand; i++){
            GameObject find = GameObject.Find(NameCards[i]);
            checkCard.Add(find.transform.position.z);
        }
        foreach (float element in checkCard){
            if (element == PosZ){
                //Debug.Log(element);
                return false;
            }
        }
        return true;
    }
}

