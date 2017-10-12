using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
		[SerializeField]
		private float _jumpForce;

		private bool _isOnGround;
		private Rigidbody _rb;

		void Start(){
			_rb = gameObject.GetComponent<Rigidbody> ();
		}

		void Update()
		{
			if (Input.GetKeyDown (KeyCode.Space) && _isOnGround) {
				_rb.AddForce (Vector3.up * _jumpForce);
				_isOnGround = false;
			}
		}

		private void OnCollisionEnter(Collision other){
			if (other.gameObject.name == "Plane") {
				_isOnGround = true;
			}
		}
		/*
		private void OnCollisionStay(Collision other){
			if (!_isOnGround && other.gameObject.name == "Plane") {
				_isOnGround = true;
			}
		}
		*/
	}
}
