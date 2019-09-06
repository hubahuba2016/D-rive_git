using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsOpen : MonoBehaviour {

	public GameObject DriveText;
	public GameObject PlayButton;
	public GameObject StatsButton;
	public GameObject UpgradeButton;
	public GameObject DonateButton;
	public GameObject QuitButton;
	public GameObject LastDistText;
	public GameObject TotalDistText;
	public GameObject LongestDistText;
	public GameObject CoinsOwnedText;
	public Text LastDist;
	public Text TotalDist;
	public Text LongestDist;
	public Text CoinsOwned;
	public GameObject BackButton;
	// Use this for initialization
	void Start () {
		LastDist = LastDistText.GetComponent<Text> ();
		TotalDist = TotalDistText.GetComponent<Text> ();
		LongestDist = LongestDistText.GetComponent<Text> ();
		CoinsOwned = CoinsOwnedText.GetComponent<Text> ();
	}

	public void openstats(){
		DriveText.SetActive (false);
		PlayButton.SetActive (false);
		StatsButton.SetActive (false);
		UpgradeButton.SetActive (false);
		DonateButton.SetActive (false);
		QuitButton.SetActive (false);
		LastDistText.SetActive (true);
		TotalDistText.SetActive (true);
		LongestDistText.SetActive (true);
		CoinsOwnedText.SetActive (true);
		BackButton.SetActive (true);
		LastDist.text = ("Last Dist. Travelled: " + PlayerPrefs.GetFloat ("LastDist").ToString ("F2") + " miles");
		TotalDist.text = ("Total Dist. Travelled: " + PlayerPrefs.GetFloat ("TotalDist").ToString ("F3") + " miles");
		LongestDist.text = ("Longest Dist. Travelled: " + PlayerPrefs.GetFloat ("HighScore").ToString ("F2") + " miles");
		CoinsOwned.text = ("Coins Owned: " + PlayerPrefs.GetFloat ("coinsowned").ToString ("F2"));
	}
	public void back(){
		DriveText.SetActive (true);
		PlayButton.SetActive (true);
		StatsButton.SetActive (true);
		UpgradeButton.SetActive (true);
		DonateButton.SetActive (true);
		QuitButton.SetActive (true);
		LastDistText.SetActive (false);
		TotalDistText.SetActive (false);
		LongestDistText.SetActive (false);
		CoinsOwnedText.SetActive (false);
		BackButton.SetActive (false);
	}

}
