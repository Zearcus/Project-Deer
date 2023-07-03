using System.Collections;
using System.Collections.Generic;
    
public class Database{
    public string nameCard = "";
    public string NameDialogue = "";

    public Dictionary<string, CardData> Card = new Dictionary<string, CardData>(){
        {"Hache",new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public Dictionary<string, string> Dialogue = new Dictionary<string, string>(){
        {"part1 dialog 1", "Ceci est le premier dialogue du jeu"}
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

