using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameObject myCanvas;
    public List<GameObject> waypoints;
    public float speed = 2f;
    int index = 0;

    private void Start() 
    {
        enabled = false;
    }
    /*IEnumerator Move()
    {
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        index++;
        yield return new WaitForFixedUpdate();
    }*/

    private void Update() 
    {
        if (enabled == true)
        {
            Vector3 destination = waypoints[index].transform.position;
            Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            transform.position = newPos;
            
            if (index < waypoints.Count-1)
            {
                index++;
            }
        }
    }

    private void OnTriggerStay(Collider col) 
    {
        if (gameObject.transform.position == col.transform.position)
        {
            speed = 0f;
        }
        Debug.Log(col);
    }
}
