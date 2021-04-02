using UnityEngine;
using RPG.Movement;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {

        private Ray lastRay;

        private void MoveToCursor()
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if we hit something move
            if (Physics.Raycast(lastRay, out hit))
            {
                GetComponent<Mover>().MoveTo(hit.point);
            }
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                MoveToCursor();
            }
        }
    }
}
