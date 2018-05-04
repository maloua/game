using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public GameObject player;
	public float x;
	public float y;
	public float z;

	private Vector3 offset;

	void Start () {
		offset = player.transform.position - new Vector3 (x, y, z);
		transform.position = offset;
	}
	
	void Update () {
		transform.position = player.transform.position - offset;
	}
}