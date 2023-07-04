using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public List<GameObject> waypoints, waypointschoice1, waypointschoice2, waypointschoice3;
    public float speed = 2f;
    public bool narration = true;
    public bool choice1, choice2, choice3 = false;
    public bool canMove;
    public EnableMove getChoice;
    GameObject getNarration;
    int index, index1, index2, index3 = 0;

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
            speed = 2f;
            if (choice1 == true)
            {
                Choice1Movement();
            }

            if (choice2 == true)
            {
                Choice2Movement();
            }

            if (narration == true)
            {
                Movement();
            }
        }
    }

    private void Movement()
    {
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
            
        if (index < waypoints.Count-1)
        {
            index++;
        }
    }

    private void Choice1Movement()
    {
        Vector3 destination = waypointschoice1[index1].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
            
        if (index1 < waypointschoice1.Count-1)
        {
            index1++;
        }
    }

    private void Choice2Movement()
    {
        Vector3 destination = waypointschoice2[index2].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
            
        if (index2 < waypointschoice2.Count-1)
        {
            index2++;
        }
    }

    private void Choice3Movement()
    {
        Vector3 destination = waypointschoice2[index3].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
            
        if (index3 < waypointschoice2.Count-1)
        {
            index3++;
        }
    }

    public void EnabledChoice1()
    {
        choice1 = !choice1;
        narration = false;
    }

    public void EnabledChoice2()
    {
        choice2 = !choice2;
        narration = false;
    }

    public void EnabledChoice3()
    {
        choice3 = !choice3;
        narration = false;
    }

    private void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "StopPoints")
        {
            enabled = false;    
            Destroy(col.gameObject);
        }
    }
}
