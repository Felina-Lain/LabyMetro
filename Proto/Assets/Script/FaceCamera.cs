using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour {

	public GameObject train;
	public int damping = 2;


	// Use this for initialization
	void Start () {

		train = GameObject.Find ("train");
		
	}
	
	// Update is called once per frame
	void Update () {

		//Vector3 lookPos = -train.transform.position - transform.position;
		//lookPos.y = 0f;
		//Quaternion rotation = Quaternion.LookRotation(lookPos);
		//transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);

		//transform.LookAt(train.transform);

		transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward);
		
	}
}
