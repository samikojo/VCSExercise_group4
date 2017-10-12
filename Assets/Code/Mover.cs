using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
        private float _cubeYRotation;

        private void Start()
        {
            _cubeYRotation = transform.rotation.y;
        }

        void Update()
		{
            if (Input.GetKey(KeyCode.Q))
            {
                RotateCube(-90f);
            }

            if (Input.GetKey(KeyCode.E))
            {
                RotateCube(90f);
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
	}
}
