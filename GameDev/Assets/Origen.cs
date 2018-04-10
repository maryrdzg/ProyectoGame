using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Origen : MonoBehaviour {
	public GameObject particula;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (particula);
	}
}
