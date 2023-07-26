using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class Database : MonoBehaviour{

    public DialogueDatabase dialog = new DialogueDatabase();
    NameDialog didi;
    
    public string NameCard = "";
    public string NameEnemies = "";
    public string NameDialogue = "";
    public int IDDialogue;
    


    public Dictionary<string, CardData> Card = new Dictionary<string, CardData>(){
        {"Hache",new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public Dictionary<string, Dialogue> dialogues = new Dictionary<string, Dialogue>(){

    };

    public void LoadFromJson()
    {

        string filePath = "Assets/Scripts/Database/Dialogue.json";
        string DialogueData = System.IO.File.ReadAllText(filePath);

        dialog = JsonUtility.FromJson<DialogueDatabase>(DialogueData);
        Debug.Log("Donnée chargée");
    }

    public Dictionary<string, EnemyData> Enemies = new Dictionary<string, EnemyData>(){

    };
}
public class CardData
{
    public string Type;

    public string Picture;

    public string Description;

    public int NA;

    public int HA;

    public int effect;
}

public class EnemyData{
    public int Hp;
    public string Picture;
    public int Attack;

}

//Dialogue Part
[System.Serializable]
public class DialogueDatabase
{
    public List<Dialogue> dialogues = new List<Dialogue>();
}

[System.Serializable]
public class NameDialog{
    public string ID;
}
[System.Serializable]
public class Dialogue
{
    public string NameCharacter;
    public string CoreText;
    public string Picture;
}

/*
    Call example:
        - Dialogue[NameDialogue].NameCharacter; calling the name with key value
        - Dialogue[NameDialogue].CoreText; calling the text with key value

    call dialogue:
        - dialog.dialogues[IDDialogue].NameCharacter;
*/
