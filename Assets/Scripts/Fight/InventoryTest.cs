using System.Collections.Generic;
using UnityEngine;

public class InventoryTest
{
    Database data = new Database();
    public int ID;
    public string GetNameDataBase(){
        data.NameCard = "Hache";
        return data.NameCard;
    }


    public List<string> random = new List<string>(){
        {"Hache"},{"Epee"},{"Arc"}
    };
}
