using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseStation : MonoBehaviour {

	public WayPoint _newtarget;

	void Update(){
		
			if (Input.GetMouseButtonDown(0)){ // if left button pressed...
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit)){
					// the object identified by hit.transform was clicked
					// do whatever you want
				print(hit.transform.name);

				if(hit.transform.name.Contains("Plane")){

						FadeOut.canFade = true;					

					 }
				}
		}

		if(FadeOut._alpha >= 1f){

			ChangeStation.target = _newtarget;

		}
	}
}