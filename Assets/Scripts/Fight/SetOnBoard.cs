using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOnBoard : MonoBehaviour
{
    MouseClickManager mouse;
    public GameObject Area;
    private int MaxSpawnArea = 4, CurrentValue = 0;
    private float PosZ;

    //create a a collider area for set cards in the board
    public void AreaSetCards(GameObject game)
    {
        if (game.tag == "Cards")
        {
            CreateColliders();
        }
    }

    private void CreateColliders()
    {
        // create colliders
        while (CurrentValue != MaxSpawnArea)
        {
            Area = Instantiate(Area, new Vector3(-1.5f, 0.3f, 2.0f + PosZ), transform.rotation);
            Area.name = "collider";
            CurrentValue++;
            PosZ = PosZ - 1.0f;
        }
        if (CurrentValue == MaxSpawnArea)
        {
            PosZ = 0.0f;
        }
    }
}