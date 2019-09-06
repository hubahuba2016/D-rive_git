using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimesPlayed : MonoBehaviour {
	private TimesPlayed _timesplayed;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("timesplayed", 0) == 0) {
			PlayerPrefs.SetInt ("carequipped", 1);
		}
		Destroy (_timesplayed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
