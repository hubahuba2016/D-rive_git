using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinsOwned : MonoBehaviour {
	public GameObject coinsownedtext;
	public Text coinsowned;
	// Use this for initialization
	void Start () {
		coinsowned = coinsownedtext.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		coinsowned.text = (":" + PlayerPrefs.GetFloat ("coinsowned"));
	}
}
