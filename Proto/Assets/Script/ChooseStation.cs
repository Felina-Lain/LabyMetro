﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseStation : MonoBehaviour {

	public WayPoint _newtarget;
	public bool _cantarget = false;

	[FMODUnity.EventRef]
	public string BipSound;

	[FMODUnity.EventRef]
	public string DoorClose;

	private GameObject train;

	void Start(){

		train = GameObject.Find("train");

	}

	void OnMouseOver(){

			if (Input.GetMouseButtonDown(0)){ // if left button pressed...
			
						FadeOut.canFade = true;
						_cantarget = true;
						FMODUnity.RuntimeManager.PlayOneShotAttached (BipSound, train);

			}
		}


	void Update(){
		
		if(FadeOut._alpha >= 0.25f && _cantarget){
			
			//FMODUnity.RuntimeManager.PlayOneShotAttached (DoorClose, train);
		}

		if(FadeOut._alpha >= 1f && _cantarget){

			print ("llaaaaa new target : " + _newtarget + " de la part de " + transform.name);
			ChangeStation.target = this.GetComponent<ChooseStation>()._newtarget;
			_cantarget = false;
		}
	}
}