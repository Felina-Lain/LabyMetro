using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTravelling : MonoBehaviour {

	public bool _chrono;

	public GameObject target;
	public float speed = 1f;
	public float _staring_wait;
	public GameObject names;
	public GameObject objectif;
	public GameObject _buttons;

	// Update is called once per frame
	void Update () {

		if (_staring_wait > 0 && _chrono) {
			_staring_wait -= Time.deltaTime;
		}

		if (_staring_wait <= 0) {

			float distance = Vector3.Distance(transform.position, target.transform.position);
			transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime / distance);
			speed += Time.deltaTime * 75;

			if (distance < 0.1) {
				RenderSettings.fog = true;
				FadeOut.canFade = true;
				names.SetActive (false);
				objectif.SetActive (true);


				if (FadeOut._alpha >= 1f) {
					target.GetComponent<Collider>().enabled = true;
					GameObject canvas = GameObject.Find ("Canvas");
					canvas.GetComponentInChildren<Text> ().enabled = true;
					FadeOut.canFade = false;
					this.gameObject.SetActive (false);
				}
			}
		}

		
	}

	public void ChangeBool(){

		_buttons.SetActive (false);
		names.SetActive (true);
		_chrono = true;

	}

}
