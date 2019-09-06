using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncColor : MonoBehaviour {
	public GameObject Car1Body;
	public GameObject Car1FrontBumper;
	public GameObject Car1RearBumper;
	public Material car1bodymat;
	public Material car1frontbumpermat;
	public Material car1rearbumpermat;
	public GameObject Car2Body;
	public GameObject Car2FrontBumper;
	public GameObject Car2Rearbumper;
	public Material car2bodymat;
	public Material car2frontbumpermat;
	public Material car2rearbumpermat;
	public Color car1bodycolor;
	public Color car1bumpercolor;
	public Color car2bodycolor;
	public Color car2bumpercolor;
	// Use this for initialization
	void Start () {
		car1bodycolor = new Color (PlayerPrefs.GetFloat ("car1bodyr",0f), PlayerPrefs.GetFloat ("car1bodyg",0.80f), PlayerPrefs.GetFloat ("car1bodyb",0f)); 
		car2bodycolor = new Color (PlayerPrefs.GetFloat ("car2bodyr",1f), PlayerPrefs.GetFloat ("car2bodyg",1f), PlayerPrefs.GetFloat ("car2bodyb",1f)); 
		car1bumpercolor = new Color (PlayerPrefs.GetFloat ("car1bumperr",0f), PlayerPrefs.GetFloat ("car1bumperg",0.36f), PlayerPrefs.GetFloat ("car1bumperb",0f));
		car2bumpercolor = new Color (PlayerPrefs.GetFloat ("car2bumperr",0.83f), PlayerPrefs.GetFloat ("car2bumperg",0.83f), PlayerPrefs.GetFloat ("car2bumperb",0.83f));
		sync ();
	}

	public void sync(){
		car1bodymat = Car1Body.GetComponent<Renderer> ().material;
		car1frontbumpermat = Car1FrontBumper.GetComponent<Renderer> ().material;
		car1rearbumpermat = Car1RearBumper.GetComponent<Renderer> ().material;
		car2bodymat = Car2Body.GetComponent<Renderer> ().material;
		car2frontbumpermat = Car2FrontBumper.GetComponent<Renderer> ().material;
		car2rearbumpermat = Car2Rearbumper.GetComponent<Renderer> ().material;
		car1bodymat.SetColor ("_Color", car1bodycolor);
		car1frontbumpermat.SetColor ("_Color", car1bumpercolor);
		car1rearbumpermat.SetColor ("_Color", car1bumpercolor);
		car2bodymat.SetColor ("_Color", car2bodycolor);
		car2frontbumpermat.SetColor ("_Color", car2bumpercolor);
		car2rearbumpermat.SetColor ("_Color", car2bumpercolor);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
