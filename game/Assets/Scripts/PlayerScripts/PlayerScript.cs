using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float speed;
	public float thrust;

	private Rigidbody rb;
	private Vector3 initialPosition;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		initialPosition = rb.position;
	}

	void FixedUpdate () {
		rb.AddTorque(transform.right * speed);

		if (IsGrounded()) {
			if (Input.GetKey(KeyCode.Space)) {
				rb.AddForce((Vector3.up * thrust), ForceMode.Impulse);
			}

			if (Input.GetKey(KeyCode.LeftArrow) && !IsLeft()) {
				rb.AddForce((Vector3.left), ForceMode.Impulse);
			}

			if (Input.GetKey(KeyCode.RightArrow) && !IsRight()) {
				rb.AddForce((Vector3.right), ForceMode.Impulse);
			}
		}
	}

	bool IsGrounded() {
		return(rb.position.y <= initialPosition.y + 0.05);
	}

	bool IsRight() {
		return(rb.position.x >= initialPosition.x + 0.8);
	}

	bool IsLeft() {
		return(rb.position.x <= initialPosition.x - 0.8);
	}
}
