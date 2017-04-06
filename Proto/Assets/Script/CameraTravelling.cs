using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTravelling : MonoBehaviour {


	public GameObject target;
	public float speed = 1f;
	public float _staring_wait;

	// Update is called once per frame
	void Update () {

		if (_staring_wait > 0) {
			_staring_wait -= Time.deltaTime;
		}

		if (_staring_wait <= 0) {

			float distance = Vector3.Distance(transform.position, target.transform.position);
			transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime / distance);
			speed += Time.deltaTime * 75;

			if (distance < 0.1) {
				RenderSettings.fog = true;
				FadeOut.canFade = true;

				if (FadeOut._alpha >= 1f) {
					target.GetComponent<Collider>().enabled = true;
					FadeOut.canFade = false;
					this.gameObject.SetActive (false);
				}
			}
		}

		
	}

}
