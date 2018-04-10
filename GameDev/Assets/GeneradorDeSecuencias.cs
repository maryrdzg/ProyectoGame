using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeSecuencias : MonoBehaviour {
	//Variables distinguir distintos tipos de patrones u objetos
	public GameObject patronA;
	public GameObject patronB;
	public GameObject patronC;
	// Use this for initialization
	void Start () {
		//Generar algun tipo de patron
		Instantiate(patronA);
		Instantiate (patronB);
		Instantiate (patronC);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
