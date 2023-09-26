using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerManager : MonoBehaviour
{
    [SerializeField] List<GameObject> triggerZones,triggerZonesChoice1,triggerZonesChoice2;

    int index, index1, index2 = 0;

    static DestroyerManager instance;

    private void Awake() 
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one DestroyerManager");
        }
        instance = this;
    }

    public static DestroyerManager GetInstance()
    {
        return instance;
    }

    public void DestroyThese()
    {
        triggerZones[index].SetActive(false);
        index++;
    }

    public void DestroyChoice1Nar()
    {
        triggerZonesChoice1[index1].SetActive(false);
        index1++;
    }

    public void DestroyChoice2Nar()
    {
       triggerZonesChoice2[index2].SetActive(false);
        index2++;
    }
}
