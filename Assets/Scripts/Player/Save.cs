using UnityEngine;

public class Save : MonoBehaviour
{

    [SerializeField]
    private float posX = 0;

    private void Start() 
    {
        if (PlayerPrefs.HasKey("PosX"))
        {

        }
    }
}
