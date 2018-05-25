using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		rb.AddTorque(transform.right * speed);

		if (Input.GetKey(KeyCode.Space)) {
			rb.AddForce(Vector3.up, ForceMode.Impulse);
		}
	}

	void Update() {
	}
}
