using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card stats", menuName = "Deck/Card stats")]

public class CardSO : ScriptableObject
{
    public string _name;
    public string _description;
    public Sprite _image;
    public int _atkDmg;
}
