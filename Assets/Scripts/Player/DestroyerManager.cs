using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerManager : MonoBehaviour
{
    public List<GameObject> triggerZones;
    public List<GameObject> triggerZonesChoice1;
    public List<GameObject> triggerZonesChoice2;

    int index = 0;

    public void DestroyThese()
    {
        Destroy(triggerZones[index].gameObject.GetComponent<ChoiceEvent>());
        index++;
    }
}
