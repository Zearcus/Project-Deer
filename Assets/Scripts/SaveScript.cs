using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveScript : MonoBehaviour
{
    string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy")
    , zone, nameCharacter;

    public TextMeshProUGUI textdate, textzone, textcharacter;

    void Update()
    {
        textdate.text = date;
        textzone.text = zone;
        textcharacter.text = nameCharacter;
    }
}
