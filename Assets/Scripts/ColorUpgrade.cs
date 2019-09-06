using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorUpgrade : MonoBehaviour {
	public GameObject car;
	public GameObject car2;
	public GameObject ColorButton;
	public GameObject PatternButton;
	public GameObject CarBodyColorButton;
	public GameObject CarBumperColorButton;
	public GameObject ColorUnlockButton;
	public GameObject NextCarButton;
	public GameObject PrevCarButton;
	public int colorisunlocked;
	public CarCounter _carcounter;
	public EventSystem _eventsystem;
	public SyncColor _synccolor;
	void Start(){
		_carcounter = GetComponent<CarCounter> ();
		_eventsystem = GetComponent<EventSystem> ();
		_synccolor = GetComponent<SyncColor> ();
		_synccolor.sync ();
	}

	public void ColorOnClick(){
		if (PlayerPrefs.GetInt ("carequipped") == 1) {
			car.SetActive (true);
			car2.SetActive (false);
			NextCarButton.SetActive (false);
			PrevCarButton.SetActive (false);
			_carcounter.carcount = 1;
			colorisunlocked = PlayerPrefs.GetInt ("color1unlock");
		} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
			car2.SetActive (true);
			car.SetActive (false);
			NextCarButton.SetActive (false);
			PrevCarButton.SetActive (false);
			_carcounter.carcount = 2;
			colorisunlocked = PlayerPrefs.GetInt ("color2unlock");
		}
		ColorButton.SetActive (false);
		PatternButton.SetActive (false);
		_eventsystem.ismain = false;
		_eventsystem.colorisclicked = true;
		if (colorisunlocked < 7) {
			ColorUnlockButton.SetActive (true);
		}else {
			CarBodyColorButton.SetActive (true);
			CarBumperColorButton.SetActive (true);
		}
	}


}
