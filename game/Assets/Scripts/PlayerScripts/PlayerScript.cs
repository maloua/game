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
	}

	bool IsGrounded() {
		return(rb.position.y <= initialPosition.y + 0.05);
	}

	void Update() {
		if (IsGrounded() && Input.GetKey(KeyCode.Space)) {
			rb.AddForce((Vector3.up * thrust), ForceMode.Impulse);
		}
	}
}
