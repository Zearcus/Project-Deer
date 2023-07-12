using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour
{
    float PosX;
    public GameObject mana;
    private GameObject ManaDestroy;
    // Update is called once per frame

    //Button test
    public void ManaTest(GameObject game)
    {
        if (game.name == "Mana bar")
            GetMana();

        if (Input.GetKeyDown(KeyCode.D))
        {
            LostMana();
        }
    }

    //Instantiate prefab mana
    public void GetMana()
    {
        ManaDestroy = Instantiate(mana, new Vector3(-0.73f + PosX, 0.5f, 5.70f), transform.rotation);

        PosX = PosX + 0.2f;

    }

    //Destroy clone mana
    public void LostMana()
    {
        var tag = GameObject.FindGameObjectWithTag("Clone");
        Destroy(tag);

    }
}
