using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerJson : MonoBehaviour
{
    // Start is called before the first frame update
    public Player _player = new Player();

    //Adding coord XYZ on player's coord in rigidBody

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))//test
        {
            LoadFromJson();
        }
    }
    // public void SaveToJson() //for the button save 
    // {
    //     string PlayerData = JsonUtility.ToJson<_player>();
    //     string FilePath = Application.persistentDataPath + "/Player.json";
    //     System.IO.File.WriteAllText(PlayerData);
    // }

    public void LoadFromJson()
    {

        string FilePath = "Assets/Database/Player.json";
        string PlayerData = System.IO.File.ReadAllText(FilePath);
        //get the objecct value on Json and add the value on the variable in the class PlayerJson
        _player = JsonUtility.FromJson<Player>(PlayerData);

        Debug.Log(_player.Name);
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
