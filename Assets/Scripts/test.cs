using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    Database _data = new Database();
    public NameCard namecard = new NameCard();

    //var RigidBodyPlayer = FindObjectsOfType<RigidBody>();
    //Adding coord XYZ on player's coord in rigidBody

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))//test
        {
            //LoadFromJson();
            Debug.Log(_data._Card[namecard]);
        }
    }
}
