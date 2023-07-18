using System.Collections;
using System.Collections.Generic;
    
public class Database{
    public string NameCard = "";
    public string NameDialogue = "";
    public string NameEnemies = "";


    public Dictionary<string, CardData> Card = new Dictionary<string, CardData>(){
        {"Hache",new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public Dictionary<string, Dialogue> Dialogue = new Dictionary<string, Dialogue>(){
        {"part1 dialog 1",new Dialogue{
            NameCharacter = "Samten",
            CoreText = "Ceci est le premier dialogue du jeu"} 
        }
    };

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

public class Dialogue{
   public string NameCharacter;
   public string CoreText;
   public string Picture;
}

/*
    Call example:
    Dialogue[NameDialogue].NameCharacter; calling the name with key value
    Dialogue[NameDialogue].CoreText; calling the text with key value
*/
