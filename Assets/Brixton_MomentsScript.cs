using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brixton_MomentsScript : MonoBehaviour {
	private AudioClip BM;
	public AudioSource Brixton_Moments;
	// Use this for initialization
	void Start () {
		Brixton_Moments = this.gameObject.GetComponent<AudioSource>();
		BM = Brixton_Moments.GetComponent<AudioClip>();
		Brixton_Moments.loop = true;
		Brixton_Moments.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
