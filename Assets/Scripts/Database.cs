using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
   public Dictionary<NameCard, Card> _Card = new Dictionary<NameCard, Card>(){
        {new NameCard{
            Name = "Hache"
        },
        new Card{
        Type = "Weapon",
        Picture = "/Pictures/Hache.png",
        Description = "Longue hache qui coupe",
        NA = 10,
        HA = 50}
        }
    };
}
public class NameCard
{
    public string Name;
}
public class Card
{
    public string Type;

    public string Picture;

    public string Description;

    public int NA;

    public int HA;

    public int effect;




}
