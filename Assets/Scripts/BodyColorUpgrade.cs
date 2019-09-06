using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyColorUpgrade : MonoBehaviour {
	public Slider bodycolorr;
	public Slider bodycolorb;
	public Slider bodycolorg;
	public GameObject bodybutton;
	public GameObject bumperbutton;
	public GameObject bodycolormanager;
	private Color colorget;
	private Color colorset;
	public GameObject carbody;
	public Material carbodymat;
	public GameObject UpgradeManager;
	public EventSystem _eventsystem;
	public GameObject SetColorButton;

	void Awake(){
		_eventsystem = UpgradeManager.GetComponent<EventSystem> ();
		if (PlayerPrefs.GetInt ("carequipped") == 1) {
			carbody = GameObject.Find ("main");
			carbodymat = carbody.GetComponent<Renderer> ().material;
			colorget = carbodymat.GetColor ("_Color");
			bodycolorr.value = colorget.r;
			bodycolorb.value = colorget.b;
			bodycolorg.value = colorget.g;
		} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
			carbody = GameObject.Find ("main2");
			carbodymat = carbody.GetComponent<Renderer> ().material;
			colorget = carbodymat.GetColor ("_Color");
			bodycolorr.value = colorget.r;
			bodycolorb.value = colorget.b;
			bodycolorg.value = colorget.g;
		}
		colorset.a = 1f;
		colorset.r = colorget.r;
		colorset.b = colorget.b;
		colorset.g = colorget.g;
	}
	public void BodyColorOnClick(){
		bodycolormanager.SetActive (true);
		bodycolorr.gameObject.SetActive (true);
		bodycolorb.gameObject.SetActive (true);
		bodycolorg.gameObject.SetActive (true);
		SetColorButton.SetActive (true);
		bodybutton.SetActive (false);
		bumperbutton.SetActive (false);
		_eventsystem.carbodyorbumpercolorisclicked = true;
		_eventsystem.colorisclicked = false;
	}
	public void BodyColorRonValueChanged(){
		colorset.r = bodycolorr.value;
	}
	public void BodyColorBonValueChanged(){
		colorset.b = bodycolorb.value;
	}
	public void BodyColorGonValueChanged(){
		colorset.g = bodycolorg.value;
	}
	public void RevertBodyColor(){
		carbodymat.SetColor ("_Color", colorget);
	}
	void Update(){
			carbodymat.SetColor ("_Color", colorset);


	}
}
