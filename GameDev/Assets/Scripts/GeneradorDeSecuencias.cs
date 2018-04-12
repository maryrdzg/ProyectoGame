﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeSecuencias : MonoBehaviour {
	//Variables distinguir distintos tipos de patrones u objetos
	public GameObject patronA;
	public GameObject patronB;
	public GameObject patronC;
	public int tipo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
	{
		DetectaTeclas (tipo);
	}
	public void DetectaTeclas(int tipo)
{
		if (Input.GetKey (KeyCode.UpArrow)) {
			//condicion para evitae crear patrones iguales simultaneos
			if (!GameObject.Find ("patronB(Clone)")) 
			{	
				tipo = 2;
				GeneraPatron (tipo);
			}
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			if (!GameObject.Find ("patronA(Clone)")) 
			{
				tipo = 1;
				GeneraPatron (tipo);
			}
		}
		if (!GameObject.Find ("patronC(Clone)"))
		{
			if (Input.GetKey (KeyCode.RightArrow)) 
			{
				tipo = 3;
				GeneraPatron (tipo);
			}
	  }
}
	public void GeneraPatron(int tipo){
		//Generar algun tipo de patron
		if (tipo == 1) 
		{
			Instantiate (patronA);
		}
		if (tipo == 2) 
		{
			Instantiate (patronB);
		}
		if (tipo == 3) 
		{
			Instantiate (patronC);
		}
	}
}