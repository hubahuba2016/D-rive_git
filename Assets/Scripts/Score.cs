using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public bool gameover;
	public float score; 
	public Text scoretext;
	public Text cointext;
	public int coinsrecieved;
	// Use this for initialization
	void Start(){
		Screen.orientation = ScreenOrientation.Portrait;
	}
	// Update is called once per frame
	void Update () {
		if (gameover == false) {
			score = Time.timeSinceLevelLoad * 40 / 1.6f / 3600;
		}
		scoretext.text = ("Dist. travelled: " + score.ToString("F2") + " miles");
		cointext.text = (coinsrecieved.ToString("F0"));
		
	}
}
