using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeRockScript : MonoBehaviour {
	public int qualitylevel;
	// Use this for initialization
	void Start () {
		qualitylevel = QualitySettings.GetQualityLevel ();
		if (qualitylevel < 3) {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
