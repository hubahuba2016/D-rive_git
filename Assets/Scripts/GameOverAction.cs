using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAction : MonoBehaviour {
	public GameObject score;
	public Score _score;
	void Start(){
		_score = score.GetComponent<Score> ();
	}
	public void backtomenu(){
		PlayerPrefs.SetFloat ("LastDist", _score.score);
		SceneManager.LoadScene ("menu3", LoadSceneMode.Single);
	}
	public void playagain(){
		PlayerPrefs.SetFloat ("LastDist", _score.score);
		SceneManager.LoadScene ("main", LoadSceneMode.Single);

	}
}
