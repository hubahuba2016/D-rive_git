using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackOnClick : MonoBehaviour {
	public GameObject UpgradeManager;
	public EventSystem _eventsystem;
	public GameObject ColorButton;
	public GameObject PatternButton;
	public GameObject ColorUnlockButton;
	public GameObject BodyColorButton;
	public GameObject BumperColorButton;
	public GameObject BodyColorManager;
	public GameObject BumperColorManager;
	public GameObject BodyColorR;
	public GameObject BodyColorB;
	public GameObject BodyColorG;
	public GameObject BumperColorR;
	public GameObject BumperColorB;
	public GameObject BumperColorG;
	public GameObject SetColorButton;
	public SetColor _setcolor;
	public BodyColorUpgrade _bodycolorupgrade;
	public BumperColorUpgrade _bumpercolorupgrade;

	void Start(){
		UpgradeManager = GameObject.Find ("UpgradeManager");
		_eventsystem = UpgradeManager.GetComponent<EventSystem> ();
		_setcolor = SetColorButton.GetComponent<SetColor> ();
		_bodycolorupgrade = BodyColorManager.GetComponent<BodyColorUpgrade> ();
		_bumpercolorupgrade = BumperColorManager.GetComponent<BumperColorUpgrade> ();
	}
	public void back(){
		if (_eventsystem.ismain == true) {
			SceneManager.LoadScene ("menu3", LoadSceneMode.Single);
		} else if (_eventsystem.colorisclicked == true) {
			_eventsystem.ismain = true;
			_eventsystem.colorisclicked = false;
			ColorButton.SetActive (true);
			PatternButton.SetActive (true);
			ColorUnlockButton.SetActive (false);
			BodyColorButton.SetActive (false);
			BumperColorButton.SetActive (false);
		} else if (_eventsystem.carbodyorbumpercolorisclicked == true) {
			_eventsystem.colorisclicked = true;
			_eventsystem.carbodyorbumpercolorisclicked = false;
			if (_setcolor.isset == false) {
				if (BodyColorManager.activeInHierarchy == true) {
					_bodycolorupgrade.RevertBodyColor ();
					BodyColorManager.SetActive (false);
				} else if (BumperColorManager.activeInHierarchy == true) {
					_bumpercolorupgrade.RevertBumperColor ();
					BumperColorManager.SetActive (false);
				}
			}
			BodyColorButton.SetActive (true);
			BumperColorButton.SetActive (true);
			BodyColorR.SetActive (false);
			BodyColorB.SetActive (false);
			BodyColorG.SetActive (false);
			BumperColorR.SetActive (false);
			BumperColorB.SetActive (false);
			BumperColorG.SetActive (false);
			SetColorButton.SetActive (false);
			_setcolor.isset = false;
		}

	}
}
