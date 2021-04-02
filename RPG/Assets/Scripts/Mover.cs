using System;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    Ray lastRay;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            MoveToCursor();
        }


    }

    private void MoveToCursor()
    {
        lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        

        //if we hit something move
        if(Physics.Raycast(lastRay, out hit))
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }

    }
}
