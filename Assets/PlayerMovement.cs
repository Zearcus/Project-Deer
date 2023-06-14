using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2f;

    public void Moving() 
    {
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        int index = 0;
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        yield return new WaitForSeconds(0);
    }
}
