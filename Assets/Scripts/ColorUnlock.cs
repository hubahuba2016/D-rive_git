using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUnlock : MonoBehaviour {
	public GameObject BodyColorButton;
	public GameObject BumperColorButton;
	public GameObject ColorUnlockButton;

	public void ColorUnlockOnClick(){
		if (PlayerPrefs.GetFloat ("coinsowned") >= 10) {
			if (PlayerPrefs.GetInt ("carequipped") == 1) {
				PlayerPrefs.SetInt ("color1unlock", 10);
				PlayerPrefs.SetFloat ("coinsowned", PlayerPrefs.GetFloat ("coinsowned") - 10f);
				BodyColorButton.SetActive (true);
				BumperColorButton.SetActive (true);
				ColorUnlockButton.SetActive (false);
			} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
				PlayerPrefs.SetInt ("color2unlock", 10);
				PlayerPrefs.SetFloat ("coinsowned", PlayerPrefs.GetFloat ("coinsowned") - 10f);
				BodyColorButton.SetActive (true);
				BumperColorButton.SetActive (true);
				ColorUnlockButton.SetActive (false);
			}
		}
	}
}
