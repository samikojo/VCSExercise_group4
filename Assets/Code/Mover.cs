using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
        [SerializeField]
        private float _jumpForce;
        protected const string horAxis = "Horizontal";
        protected const string verAxis = "Vertical";

        private bool _isOnGround;
        private Vector3 moveVector;

        private Rigidbody _rb;
        private float _cubeYRotation;

        private void Start()
        {
            _cubeYRotation = transform.rotation.y;
            _rb = gameObject.GetComponent<Rigidbody>();
        }

        void Update()
		{
            moveVector = GetMovement();
            transform.Translate(moveVector);

            if (Input.GetKey(KeyCode.Q))
            {
                RotateCube(-90f);
            }

            if (Input.GetKey(KeyCode.E))
            {
                RotateCube(90f);
            }

            if (Input.GetKeyDown(KeyCode.Space) && _isOnGround)
            {
                _rb.AddForce(Vector3.up * _jumpForce);
                _isOnGround = false;
            }
        }

        /*// rotation scripting with Euler angles correctly.
        // here we store our Euler angle in a class variable, and only use it to
        // apply it as a Euler angle, but we never rely on reading the Euler back.

        float x;
        void Update()
        {

            x += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(x, 0, 0);

        }*/

        private void RotateCube(float rotationAmount)
        {
            _cubeYRotation += rotationAmount * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, _cubeYRotation, 0f);
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
