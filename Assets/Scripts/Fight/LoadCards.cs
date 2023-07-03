using UnityEngine;
using TMPro;

public class LoadCards : MonoBehaviour
{
    public TextMeshPro textName, textAttack, textMana;
    Database data = new Database();
    // Start is called before the first frame update
    void Start()
    {
        data.nameCard = "Hache";
        LoadingCards();
    }

    void LoadingCards(){
        textName.text = data.nameCard;
        textAttack.text = data.Card[data.nameCard].NA.ToString();
        textMana.text = data.Card[data.nameCard].HA.ToString();
    }

    //faire un système de loading de carte par type de carte quand on pioche.
}
