using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous_RootsAndGigantic_MoonScript : MonoBehaviour {
private AudioClip DR;
private AudioClip GM;
public AudioSource Dangerous_Roots;
public AudioSource Gigantic_Moon;
public int musicplay;
	// Use this for initialization
	void Start () {
		DR = Dangerous_Roots.GetComponent<AudioClip>();
		GM = Gigantic_Moon.GetComponent<AudioClip>();
		musicplay = Random.Range(1,3);
		if(musicplay == 1){
			Dangerous_Roots.loop = false;
			Dangerous_Roots.Play();
		}else if (musicplay == 2){
			Gigantic_Moon.loop = false;
			Gigantic_Moon.Play();
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Dangerous_Roots.isPlaying == false && Gigantic_Moon.isPlaying == false){
			musicplay = Random.Range(1,3);
		}
		if(musicplay == 1){
			Dangerous_Roots.loop = false;
			Dangerous_Roots.Play();
		}
		else if(musicplay == 2){
			Gigantic_Moon.loop = false;
			Gigantic_Moon.Play();
		}
	}
}
