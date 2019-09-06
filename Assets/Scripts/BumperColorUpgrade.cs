using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BumperColorUpgrade : MonoBehaviour {
	public Slider bumpercolorr;
	public Slider bumpercolorb;
	public Slider bumpercolorg;
	public GameObject bodybutton;
	public GameObject bumperbutton;
	public GameObject bumpercolormanager;
	private Color colorget;
	private Color colorset;
	public GameObject frontbumper;
	public Material frontbumpermat;
	public GameObject rearbumper;
	public Material rearbumpermat;
	public GameObject UpgradeManager;
	public EventSystem _eventsystem;
	public GameObject SetColorButton;

	void Awake(){
		_eventsystem = UpgradeManager.GetComponent<EventSystem> ();
		if (PlayerPrefs.GetInt ("carequipped") == 1) {
			frontbumper = GameObject.Find ("front_bumper");
			frontbumpermat = frontbumper.GetComponent<Renderer> ().material;
			rearbumper = GameObject.Find ("rear_bumper");
			rearbumpermat = rearbumper.GetComponent<Renderer> ().material;
			colorget = frontbumpermat.GetColor ("_Color");
			bumpercolorr.value = colorget.r;
			bumpercolorb.value = colorget.b;
			bumpercolorg.value = colorget.g;
		} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
			frontbumper = GameObject.Find ("Front Bumper");
			frontbumpermat = frontbumper.GetComponent<Renderer> ().material;
			rearbumper = GameObject.Find ("Rear Bumper");
			rearbumpermat = rearbumper.GetComponent<Renderer> ().material;
			colorget = frontbumpermat.GetColor ("_Color");
			bumpercolorr.value = colorget.r;
			bumpercolorb.value = colorget.b;
			bumpercolorg.value = colorget.g;
		}
		colorset.a = 1f;
		colorset.r = colorget.r;
		colorset.b = colorget.b;
		colorset.g = colorget.g;
	}
	public void BumperColorOnClick(){
		bumpercolormanager.SetActive (true);
		bumpercolorr.gameObject.SetActive (true);
		bumpercolorb.gameObject.SetActive (true);
		bumpercolorg.gameObject.SetActive (true);
		SetColorButton.SetActive (true);
		bodybutton.SetActive (false);
		bumperbutton.SetActive (false);
		_eventsystem.carbodyorbumpercolorisclicked = true;
		_eventsystem.colorisclicked = false;
	}
	public void BumperColorRonValueChanged(){
		colorset.r = bumpercolorr.value;
	}
	public void BumperColorBonValueChanged(){
		colorset.b = bumpercolorb.value;
	}
	public void BumperColorGonValueChanged(){
		colorset.g = bumpercolorg.value;
	}
	public void RevertBumperColor(){
		frontbumpermat.SetColor ("_Color", colorget);
		rearbumpermat.SetColor ("_Color", colorget);
	}
	void Update(){
		frontbumpermat.SetColor ("_Color", colorset);
		rearbumpermat.SetColor ("_Color", colorset);

	}
}

