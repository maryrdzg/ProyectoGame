﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class GeneradorDeSecuencias : MonoBehaviour {
=======
public class GeneradorDeSecuencias : MonoBehaviour 
{
>>>>>>> upstream/master
	//Variables distinguir distintos tipos de patrones u objetos
	public GameObject patronA;
	public GameObject patronB;
	public GameObject patronC;
	public int tipo;
	// Use this for initialization
	void Start () {
<<<<<<< HEAD

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
=======
		Debug.Log (((8 + 4) * ((2 + 1) / 2)));
	
	}
	// Update is called once per frame
	void Update ()	
	{
		DetectaTeclas (tipo);
	}

	public void DetectaTeclas(int tipo)
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			//condicion para evitar crear patrones iguales simultaneos
			if(!GameObject.Find("patronB(Clone)"))
			{
>>>>>>> upstream/master
				tipo = 2;
				GeneraPatron (tipo);
			}
		}
<<<<<<< HEAD
		if (Input.GetKey (KeyCode.LeftArrow)) 
=======
		if(Input.GetKey(KeyCode.LeftArrow))
>>>>>>> upstream/master
		{
			if (!GameObject.Find ("patronA(Clone)")) 
			{
				tipo = 1;
				GeneraPatron (tipo);
			}
		}
<<<<<<< HEAD
		if (!GameObject.Find ("patronC(Clone)"))
		{
			if (Input.GetKey (KeyCode.RightArrow)) 
=======
		if(Input.GetKey(KeyCode.RightArrow))
		{
			if (!GameObject.Find ("patronC(Clone)")) 
>>>>>>> upstream/master
			{
				tipo = 3;
				GeneraPatron (tipo);
			}
<<<<<<< HEAD
	  }
}
	public void GeneraPatron(int tipo){
=======
		}
	}
	public void GeneraPatron(int tipo)
	{
>>>>>>> upstream/master
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