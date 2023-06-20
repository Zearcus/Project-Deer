using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerJson : MonoBehaviour
{
    // Start is called before the first frame update
    public Player _player = new Player();

    //var RigidBodyPlayer = FindObjectsOfType<RigidBody>();
    //Adding coord XYZ on player's coord in rigidBody

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))//test
        {
            LoadFromJson();
        }
    }
    public void SaveToJson() //for the button save 
    {
    //     _player.PosX = RigidBodyPlayer.velocity.x;
    //     _player.PosY = RigidBodyPlayer.velocity.y;
    //     _player.PosZ = RigidBodyPlayer.velocity.z;
        string PlayerData = JsonUtility.ToJson(_player);
        string FilePath = Application.persistentDataPath + "/Player.json";
        System.IO.File.WriteAllText(FilePath, PlayerData);
    }

    public void LoadFromJson()
    {
        /*
        _player.PosX = RigidBodyPlayer.velocity.x;
        _player.PosY = RigidBodyPlayer.velocity.y;
        _player.PosZ = RigidBodyPlayer.velocity.z;
        */
        string FilePath = "Assets/Database/Player.json";
        string PlayerData = System.IO.File.ReadAllText(FilePath);
        //get the objecct value on Json and add the value on the variable in the class PlayerJson
        _player = JsonUtility.FromJson<Player>(PlayerData);

    }
}
[System.Serializable]// make the object to modifiable variable
public class Player
{
    public string Name;
    public int Hp;
    public int Mana;
    public float PosX;
    public float PosY;
    public float PosZ;
}
