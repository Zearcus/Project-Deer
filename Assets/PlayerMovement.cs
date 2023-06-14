using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameObject myCanvas;
    public List<GameObject> waypoints;
    public float speed = 2f;

    private void Start() 
    {
        enabled = false;
    }
    IEnumerator Move()
    {
        int index = 0;
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        yield return new WaitForFixedUpdate();
    }

    private void Update() 
    {
        if (enabled == true)
        {
            StartCoroutine(Move());

            foreach (Transform element in GameObject.FindWithTag("Canvas").transform)
            {
                element.gameObject.SetActive(false);
            }
              
        }
    }
}
