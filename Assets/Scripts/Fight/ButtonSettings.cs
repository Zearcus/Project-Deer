using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    public GameObject Collider;
    private int CurrentValue;
    //private bool isActivate = false;

    public void SetArea(GameObject game){
        if(game.name == ("Button Summon")){
            CreateColliders();
        }
        // if (game.tag != "Collider" && isActivate == true){
        //     DestroyColliders();
        // }
    }

    private void CreateColliders()
    {
        int MaxValue = 4;
        float PosZ = 0.0f;
        // create colliders
        while (CurrentValue != MaxValue)
        {
            CurrentValue++;
            GameObject Area = Instantiate(Collider, new Vector3(-0.5f, 0.3f, 2.0f + PosZ), Quaternion.Euler(0.0f, 90.0f, 0.0f));
            Area.name = "Collider" + " " + SetLetterCollider();
            Area.tag = "Collider";
            PosZ = PosZ - 1.0f;
        }
    }

    private void DestroyColliders()
    {
        while (CurrentValue != 0)
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
}

