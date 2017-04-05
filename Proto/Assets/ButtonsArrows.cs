﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsArrows : MonoBehaviour {

	public GameObject prefab;
	public float dist;

	// Use this for initialization
	void OnTriggerEnter (Collider _col) {

		Vector3 _aim;
		if (_col.tag == "MainCamera") {
			for (int i = 0; i < GetComponent<WayPoint> ().outs.Count; i++) {
		
				_aim = GetComponent<WayPoint> ().outs [i].waypoint.gameObject.transform.position;

				Vector3 vector = _aim - transform.position;

				GameObject newGameObject = GameObject.Instantiate (prefab);

				newGameObject.transform.parent = transform;

				newGameObject.transform.position = transform.position + vector.normalized * dist;
				newGameObject.transform.position = new Vector3(newGameObject.transform.position.x, newGameObject.transform.position.y - 20f, newGameObject.transform.position.z);

				newGameObject.transform.LookAt( GetComponent<WayPoint> ().outs [i].waypoint.gameObject.transform.position ) ;

				newGameObject.GetComponent<MeshRenderer>().material.color = Color.red;
		
			}
		
		}
	}
	
	// Update is called once per frame
	void OnTriggerExit() {
		
		Transform[] allTransforms = gameObject.GetComponentsInChildren<Transform>();

		foreach(Transform childObjects in allTransforms){
			if(gameObject.transform.IsChildOf(childObjects.transform) == false)
				Destroy(childObjects.gameObject);
		}
		
	}
}