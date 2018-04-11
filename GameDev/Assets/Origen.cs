using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Origen : MonoBehaviour {
	public GameObject particula;
	//para controlar la direccion del movimiento
	public int dir;
	// Use this for initialization
	void Start () {
		dir = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//Creamos nuevas particulas en la misma posicion del origen
		Instantiate (particula,this.transform.position,Quaternion.identity);
		//mover el origen con codigo
		if (this.transform.position.x > 100.0f) {
			dir = -1;
		} else {
			if(this.transform.position.x < -100.0f)
			{
				dir = 1;
			}
		}
		transform.Translate (Vector3.right * (Time.deltaTime * 500.0f*dir));
	}
}
