using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetColor : MonoBehaviour {
	public bool isset;
	public GameObject BodyColorManager;
	public BodyColorUpgrade _bodycolorupgrade;
	public GameObject BumperColorManager;
	public BumperColorUpgrade _bumpercolorupgrade;
	public GameObject backbutton;
	public BackOnClick _backonclick;
	void Start(){
		isset = false;
		_bodycolorupgrade = BodyColorManager.GetComponent<BodyColorUpgrade> ();
		_bumpercolorupgrade = BumperColorManager.GetComponent<BumperColorUpgrade> ();
		_backonclick = backbutton.GetComponent<BackOnClick> ();
	}
	public void SetOnClick(){
		if (BodyColorManager.activeInHierarchy == true) {
			if (PlayerPrefs.GetInt ("carequipped") == 1) {
				isset = true;
				PlayerPrefs.SetFloat ("car1bodyr", _bodycolorupgrade.bodycolorr.value);
				PlayerPrefs.SetFloat ("car1bodyb", _bodycolorupgrade.bodycolorb.value);
				PlayerPrefs.SetFloat ("car1bodyg", _bodycolorupgrade.bodycolorg.value);
				_backonclick.back ();
			} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
				isset = true;
				PlayerPrefs.SetFloat ("car2bodyr", _bodycolorupgrade.bodycolorr.value);
				PlayerPrefs.SetFloat ("car2bodyb", _bodycolorupgrade.bodycolorb.value);
				PlayerPrefs.SetFloat ("car2bodyg", _bodycolorupgrade.bodycolorg.value);
				_backonclick.back ();
			}
		} else if (BumperColorManager.activeInHierarchy == true) {
			if (PlayerPrefs.GetInt ("carequipped") == 1) {
				isset = true;
				PlayerPrefs.SetFloat ("car1bumperr", _bumpercolorupgrade.bumpercolorr.value);
				PlayerPrefs.SetFloat ("car1bumperb", _bumpercolorupgrade.bumpercolorb.value);
				PlayerPrefs.SetFloat ("car1bumperg", _bumpercolorupgrade.bumpercolorg.value);
				_backonclick.back ();
			} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
				isset = true;
				PlayerPrefs.SetFloat ("car2bumperr", _bumpercolorupgrade.bumpercolorr.value);
				PlayerPrefs.SetFloat ("car2bumperb", _bumpercolorupgrade.bumpercolorb.value);
				PlayerPrefs.SetFloat ("car2bumperg", _bumpercolorupgrade.bumpercolorg.value);
				_backonclick.back ();
			}
		}
	}
}
