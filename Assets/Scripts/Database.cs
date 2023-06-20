using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database{
    public string nameCard = "Hache";

    public Dictionary<string, CardData> CardDataBase = new Dictionary<string, CardData>(){
        {"Hache",
        new CardData{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };

    public List <string> Deck = new List<string>();
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

