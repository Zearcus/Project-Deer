using UnityEngine;
using TMPro;

public class LoadCards : MonoBehaviour
{
    public TextMeshPro textName, textAttack, textMana, textType;
    Database data = new Database();

    InventoryTest inventory = new InventoryTest();
    // Start is called before the first frame update
    void Start()
    {
        //data.NameCard = "Hache";
        LoadingCards();
    }

    void LoadingCards(){
        textName.text = inventory.GetNameDataBase();
        textType.text = data.Card[textName.text].Type.ToString();
        textAttack.text = data.Card[textName.text].NA.ToString();
        textMana.text = data.Card[textName.text].HA.ToString();
    }

    //faire un système de loading de carte par type de carte quand on pioche.
}
