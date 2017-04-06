using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsArrows : MonoBehaviour {
	
	// Use this for initialization
	void OnTriggerEnter (Collider _col) {

		if(ChangeStation.target == this.GetComponent<WayPoint>()){
			FadeOut.canFade = false;
		}

		foreach(Transform child in transform)
		{
			child.transform.gameObject.SetActive(true);
		}

		

	}
	
	// Update is called once per frame
	void OnTriggerExit() {
		
		Transform[] allTransforms = gameObject.GetComponentsInChildren<Transform>();

		foreach(Transform childObjects in allTransforms){
			if(gameObject.transform.IsChildOf(childObjects.transform) == false)
				childObjects.gameObject.SetActive(false);
		}
		
	}
}
