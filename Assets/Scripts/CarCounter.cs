using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCounter : MonoBehaviour {
	public GameObject car1;
	public GameObject car2;
	public GameObject tank1;
	public GameObject nextcarbutton;
	public GameObject prevcarbutton;
	public GameObject carequipbutton;
	public GameObject unlockbutton;
	public int carcount;
	public EventSystem _eventsystem;
	// Use this for initialization
	void Start () {
		carcount = PlayerPrefs.GetInt ("carequipped",1);
		_eventsystem = GetComponent<EventSystem> ();
	}
	void Update(){
		if (carcount == 1) {
			car1.SetActive (true);
			car2.SetActive (false);
			tank1.SetActive (false);
			unlockbutton.SetActive (false);
			if (PlayerPrefs.GetInt ("carequipped") != carcount) {
				carequipbutton.SetActive (true);
			} else {
				carequipbutton.SetActive (false);
			}
		} else if (carcount == 2) {
			car1.SetActive (false);
			car2.SetActive (true);
			tank1.SetActive (false);
			if (PlayerPrefs.GetInt ("carequipped") != carcount) {
				if (PlayerPrefs.GetInt ("car2isunlocked") < 3) {
					unlockbutton.SetActive (true);
				} else {
					unlockbutton.SetActive (false);
				}
				carequipbutton.SetActive (true);
			} else {
				carequipbutton.SetActive (false);
			}
		} else if (carcount == 3) {
			car1.SetActive (false);
			car2.SetActive (false);
			tank1.SetActive (true);
			if (PlayerPrefs.GetInt ("carequipped") != carcount) {
				if (PlayerPrefs.GetInt ("tank1isunlocked") < 3) {
					unlockbutton.SetActive (true);
				} else {
					unlockbutton.SetActive (false);
				}
				carequipbutton.SetActive (true);
			} else {
				carequipbutton.SetActive (false);
			}
		}
		if (carcount > 1 && carcount < 3 && _eventsystem.colorisclicked == false && _eventsystem.carbodyorbumpercolorisclicked == false) {
			prevcarbutton.SetActive (true);
			nextcarbutton.SetActive (true);
		} else if (carcount == 1 && _eventsystem.colorisclicked == false && _eventsystem.carbodyorbumpercolorisclicked == false) {
			prevcarbutton.SetActive (false);
		} else if (carcount == 3 && _eventsystem.colorisclicked == false && _eventsystem.carbodyorbumpercolorisclicked == false) {
			nextcarbutton.SetActive (false);
		}
		if (_eventsystem.colorisclicked == true) {
			nextcarbutton.SetActive (false);
			prevcarbutton.SetActive (false);
		}
	}
	public void nextcaronclick(){
		carcount += 1;
	}
	public void prevcaronclick(){
		carcount -= 1;
	}
	public void equipbuttononclick(){
		PlayerPrefs.SetInt ("carequipped", carcount);
		carequipbutton.SetActive (false);
	}

}
