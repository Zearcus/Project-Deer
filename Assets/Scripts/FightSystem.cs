using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System;
using System.IO;
using UnityEditor;

public class FightSystem : MonoBehaviour
{
    private static string save = "0";
    private static string inventoryCSVpath = "/CSV/inventory" + save + ".csv";

    List<List<string>> deck = new List<List<string>>() { 
        new List<string>() {  },        //weapons
        new List<string>() {  },        //spells 
        new List<string>() {  }         //utilities
    };

    private List<GameObject> cardsInHand;
    private List<GameObject> cardsInDrawPile;

    public void LoadInventory()
    {
        Debug.Log(inventoryCSVpath);
        StreamReader reader = null;
        if (File.Exists(Application.dataPath + inventoryCSVpath))
        {
            reader = new StreamReader(File.OpenRead(Application.dataPath + inventoryCSVpath));
            int x = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                foreach (var item in values)
                {
                    deck[x].Add(item);
                }
                x++;
            }
            foreach (var value in deck[0])
            {
                Debug.Log(value);
            }
            reader.Close();
        }
        else
        {
            Debug.Log("rip");
        }
    }

    public void SaveInventory()
    {
        StreamWriter writer = new StreamWriter(Application.dataPath + inventoryCSVpath);
        if (File.Exists(Application.dataPath + inventoryCSVpath))
        {
            for (int  i = 0; i < deck.Count; i++)
            {
                int j;
                for (j = 0; j < deck[i].Count - 1; j++)
                {
                    writer.Write(deck[i][j] + ";");
                    Debug.Log(deck[i][j]);
                }
                writer.Write(deck[i][j] + System.Environment.NewLine);
            }
            writer.Close();
        }
        else
        {
            Debug.Log("rip");
        }
    }

    public void AddCardToInventory()
    {
        deck[0].Add("abricot");
    }

    public void Shuffle()
    {
        
    }

    private void DrawCard()
    {
       
    }

    private void FightLoop()
    {
        if (cardsInDrawPile.Count > 0)
        {
            DrawCard();
        }
    }
}
