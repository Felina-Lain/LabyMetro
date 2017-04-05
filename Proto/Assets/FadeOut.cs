using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	public Image img;
	public bool canFade;
	private Color alphaColor;

	public void Start()
	{
		canFade = false;
	}
	public void Update()
	{
		if (canFade)
		{
			FadingOut();
		}else{
			FadingIn();
		}
	}

	public void OnOff_Fade(){

		canFade = !canFade;

	}

	private void FadingOut(){
		float i = img.color.a;
		if(i > 0){i -= Time.deltaTime;}
		img.color = new Color(0, 0, 0, i);

	}

	private void FadingIn(){

		float i = img.color.a;
		if(i < 1){i += Time.deltaTime;}
		img.color = new Color(0, 0, 0, i);

	}
}
