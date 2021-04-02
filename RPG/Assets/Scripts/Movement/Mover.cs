using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private Vector3 velocity;
        private Vector3 localVelocity;

        // Update is called once per frame
        void Update()
        {
            /*if (Input.GetMouseButton(0))
            {
                MoveToCursor();
            }*/

            UpdateAnimator();
        }

        private void UpdateAnimator()
        {
            velocity = GetComponent<NavMeshAgent>().velocity;
            localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("ForwardSpeed", speed);
        }



        public void MoveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }
    }

}

