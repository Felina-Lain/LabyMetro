using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	public Image img;
	public static bool canFade;
	public static float _alpha;
	public float fadeout_speed;
	public float fadein_speed;

	public void Start()
	{
		canFade = false;
	}
	public void Update()
	{
		if (canFade)
		{
			FadingOut();
		}else if(!canFade){
			FadingIn();
		}
	}

	private void FadingOut(){ //goes black, alpha goes to max 1
		print("out");
		float i = img.color.a;
		if(i < 1){i += Time.deltaTime * fadeout_speed;}
		img.color = new Color(0, 0, 0, i);
		_alpha = i;

	}

	private void FadingIn(){ //goes transparent, alpha goes to 0
		print("in");
		float i = img.color.a;
		if(i > 0){i -= Time.deltaTime * fadein_speed;}
		img.color = new Color(0, 0, 0, i);
		_alpha = i;

	}
}
