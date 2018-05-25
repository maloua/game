using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public GameObject player;

	private Vector3 offset;

	void Start () {
		offset = player.transform.position - Camera.main.transform.position;
		transform.position = offset;
	}

	void Update () {
		transform.position = player.transform.position - offset;
	}
}
