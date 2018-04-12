using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaEscenarioControl : MonoBehaviour {
	public Transform target;
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			transform.LookAt (target);
			transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X")*speed);
		}
	}
}
