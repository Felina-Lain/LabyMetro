using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStation : MonoBehaviour {

	public static WayPoint target = null;
	public float speed = 1f;
	private Transform t;

	// Use this for initialization
	void Start () {

		t = this.gameObject.transform;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(target != null){
		//Distance between the square and the current target waypoint
		float distance = Vector3.Distance(t.position, target.transform.position);
			print("dist " + distance);
		//Move the square towards the current target
		t.position = Vector3.Lerp(t.position, target.transform.position, speed * Time.deltaTime / distance);
		t.LookAt(target.gameObject.transform);
		//In case the square arrived to the target waypoint (very small distance)
			if (distance < 0.1)
				target = null;
			}
		
	}
		
}
