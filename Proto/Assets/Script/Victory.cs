﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour {

	private string filler;
	private GameObject canvas;
	public GameObject fireworks;

	// Use this for initialization
	void Start () {

		filler = "Vous voulez\naller à : ";
		canvas = GameObject.Find ("Canvas");
		
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider _col) {

		if(_col.gameObject.GetComponentInChildren<TextMesh> () != null){
			string _amOn = _col.gameObject.GetComponentInChildren<TextMesh> ().text;
		string _iWant = canvas.GetComponentInChildren<Text> ().text;


		if (_iWant == filler + _amOn) {

			fireworks.SetActive (true);
			canvas.GetComponentInChildren<Text> ().text = "GAGNEE!!!";
			}
		}
	}
		
}
