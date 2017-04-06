using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStation : MonoBehaviour {

	public static WayPoint target = null;
	public float speed = 1f;


	
	// Update is called once per frame
	void Update () {

		print (target);

		if(target != null){
		//Distance between the square and the current target waypoint
		float distance = Vector3.Distance(transform.position, target.transform.position);
		//print("dist " + distance);
		//Move the square towards the current target
		transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime / distance);
		transform.LookAt(target.gameObject.transform);
			if (distance < 0.1) {
				target = null;
			}
		}
		
	}
		
}
