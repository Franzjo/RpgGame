using System;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;
    private Vector3 localVelocity;
    
    Ray lastRay;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        velocity = GetComponent<NavMeshAgent>().velocity;
        localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
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
