using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
        protected const string horAxis = "Horizontal";
        protected const string verAxis = "Vertical";

        private Vector3 moveVector;

        void Update()
		{
            moveVector = GetMovement();

            transform.Translate(moveVector);
		}

        private Vector3 GetMovement()
        {
            float horizontal = Input.GetAxis(horAxis);
            float vertical = Input.GetAxis(verAxis);

            Vector3 newVector = new Vector3(horizontal, 0, vertical);

            return newVector;
        }
	}
}
