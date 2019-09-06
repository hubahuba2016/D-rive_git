using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCar2 : MonoBehaviour {

	public void car2unlockonclick(){
		if (PlayerPrefs.GetFloat ("coinsowned") >= 30) {
			PlayerPrefs.SetFloat ("coinsowned", PlayerPrefs.GetFloat ("coinsowned") - 30);
			PlayerPrefs.SetInt ("car2isunlocked", 5);
			this.gameObject.SetActive (false);
		}
	}
}
