using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    public GameObject Collider;
    private int CurrentValue;

    public void SetArea(GameObject game){
        if(game.tag == ("Button")){
            CreateColliders();
        }
        else if (game.tag != ("Button")){
            DestroyColliders();
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
            Area.name = "Collider" + " " + SetLetterCollider();
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

