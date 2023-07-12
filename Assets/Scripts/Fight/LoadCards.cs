using UnityEngine;
using TMPro;

public class LoadCards : MonoBehaviour
{
    public TextMeshPro textName, textAttack, textMana, textType;
    Database data = new Database();

    InventoryTest test = new InventoryTest();
    // Start is called before the first frame update
    void Start()
    {
        //data.NameCard = "Hache";
        LoadingCards();
    }

    void LoadingCards(){
        textName.text = test.GetNameDataBase();
        textType.text = data.Card[test.GetNameDataBase()].Type.ToString();
        textAttack.text = data.Card[test.GetNameDataBase()].NA.ToString();
        textMana.text = data.Card[test.GetNameDataBase()].HA.ToString();
    }

    //faire un système de loading de carte par type de carte quand on pioche.
}
