using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    Database _data = new Database();
    //public NameCard namecard = new NameCard();
    public int varTest;
    //var RigidBodyPlayer = FindObjectsOfType<RigidBody>();
    //Adding coord XYZ on player's coord in rigidBody

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))//test
        {
            //LoadFromJson();
            Debug.Log(_data.CardDataBase[_data.nameCard]);
        }

    }

    //create adding card function on the deck
    public void add()
    {
        _data.Deck.Add(_data.nameCard);
    }
    //create delete card function on the deck
    public void delete()
    {
        _data.Deck.Remove(_data.nameCard);
    }

    public void refresh()
    {
        Debug.Log(_data.Deck[varTest]);
    }
}
