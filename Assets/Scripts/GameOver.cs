using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	public GameObject playagainbutton;
	public GameObject gotomenubutton;
	public GameObject highscoretext;
	private Text highscoretextext;
	public GameObject gameoverscoretext;
	private Text gameoverscore;
	public GameObject lastdisttext;
	public Text lastdist;
	public GameObject gameovermask;
	public GameObject gameovertext;
	private float gameoverlerp = 1f;
	private bool gameover;
	public GameObject score;
	public Score _score;
	public GameObject bronzecoin;
	public GameObject silvercoin;
	public GameObject goldcoin;
	public GameObject platinumcoin;
	private float coinsrecieved;
	// Use this for initialization
	void Start () {
		_score = score.GetComponent<Score> ();
		gameoverscore = gameoverscoretext.GetComponent<Text> ();
		highscoretextext = highscoretext.GetComponent<Text> ();
		lastdist = lastdisttext.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		Time.timeScale = gameoverlerp;
		gameover = _score.gameover;
		if (gameover == true) {
			gameoverlerp = Mathf.Lerp (gameoverlerp, 0, Time.deltaTime * 3f);
			gameovermask.SetActive (true);
			gameovertext.SetActive (true);
			gotomenubutton.SetActive (true);
			gameoverscoretext.SetActive (true);
			highscoretext.SetActive (true);
			playagainbutton.SetActive (true);
			lastdisttext.SetActive (true);
			PlayerPrefs.SetInt ("timesplayed", PlayerPrefs.GetInt ("timesplayed") + 1);
			gameoverscore.text = ("Dist. travelled: " + _score.score.ToString("F2") + " miles");
			PlayerPrefs.SetFloat ("TotalDist", PlayerPrefs.GetFloat ("TotalDist") + _score.score);
			if (_score.score > PlayerPrefs.GetFloat ("HighScore")) {
				PlayerPrefs.SetFloat ("HighScore", _score.score);
			}
			highscoretextext.text = ("Longest dist. travelled: " + PlayerPrefs.GetFloat ("HighScore").ToString ("F3") + " miles");
			if (_score.score > 1f && _score.score <= 1.5f) {
				lastdist.text = ("You get 1 coins");
				PlayerPrefs.SetFloat ("coinsowned", (PlayerPrefs.GetFloat ("coinsowned") + 1));
				bronzecoin.SetActive (true);
			} else if (_score.score > 1.5f && _score.score <= 2f) {
				lastdist.text = ("You get 2 coins");
				PlayerPrefs.SetFloat ("coinsowned", (PlayerPrefs.GetFloat ("coinsowned") + 2));
				silvercoin.SetActive (true);
			} else if (_score.score > 2f && _score.score <= 2.5f) {
				lastdist.text = ("You get 3 coins");
				PlayerPrefs.SetFloat ("coinsowned", (PlayerPrefs.GetFloat ("coinsowned") + 3));
				goldcoin.SetActive (true);
			} else if (_score.score > 2.5f) {
				coinsrecieved = _score.score / 0.5f;
				lastdist.text = ("You get more than 5 coins");
				PlayerPrefs.SetFloat ("coinsowned", (PlayerPrefs.GetFloat("coinsowned")+_score.score/0.5f));
				platinumcoin.SetActive (true);
			} else {
				lastdist.text = ("You get 0 coins");
			}
			score.SetActive (false);

		}
		
	}
}
