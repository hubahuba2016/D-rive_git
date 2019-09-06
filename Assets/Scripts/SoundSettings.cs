using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour {
	public GameObject maskimage;
	public GameObject soundsettingstext;
	public GameObject enablemusictext;
	public GameObject enablemusicon;
	public GameObject enablemusicoff;
	//public GameObject enablesoundeffectstext;
	//public GameObject soundeffectson;
	//public GameObject soundeffectsoff;
	public GameObject jukedeckcredits;
	//public GameObject volumetext;
	//public Slider volumeslider;
	public GameObject continuebutton;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void continueonclick(){
		//PlayerPrefs.SetFloat ("volume", volumeslider.value);
		Destroy (soundsettingstext.gameObject);
		Destroy (enablemusictext.gameObject);
		Destroy (enablemusicon.gameObject);
		Destroy (enablemusicoff.gameObject);
		//Destroy (enablesoundeffectstext.gameObject);
		//Destroy (soundeffectson.gameObject);
		//Destroy (soundeffectsoff.gameObject);
		Destroy (jukedeckcredits.gameObject);
		//Destroy (volumetext.gameObject);
		//Destroy (volumeslider.gameObject);
		Destroy (continuebutton.gameObject);
		Destroy (maskimage.gameObject);
	}
}
