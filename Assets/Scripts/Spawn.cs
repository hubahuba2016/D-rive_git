using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour {
	public int number_of_spawn;
	public int number_of_tree_spawn;
	private int spawnposition;
	private int treespawnposition;
	public GameObject obstacle;
	public GameObject tree;
	public bool allclear;
	public bool spawn_activate;
	public bool spawn_trees;
	public bool rightisoccupied;
	public bool midisoccupied;
	public bool leftisoccupied;
	public bool righttreeisoccupied;
	public bool lefttreeisoccupied;
	private Quaternion rootsrotation;
	private Quaternion treerotation;
	private Vector3 rightpos;
	private Vector3 midpos;
	private Vector3 leftpos;
	private Vector3 treeright;
	private Vector3 treeleft;
	public Score _score;
	public GameObject scoresource;
	private float waittime;
	// Use this for initialization
	void Start () { 
		_score = scoresource.GetComponent<Score> ();
		rootsrotation.eulerAngles = new Vector3 (0f,180f,90f);
		treerotation.eulerAngles = new Vector3 (-180f, 0f, 0f);
		rightpos = new Vector3(2.5f,90f,-0.06f);
		midpos = new Vector3 (0f,90f,-0.06f);
		leftpos = new Vector3 (-2.5f,90f,-0.06f);
		treeright = new Vector3 (6.07f, 90f, 0.06f);
		treeleft = new Vector3 (-5.83f, 90f, 0.06f);
		spawn_trees = true;
		spawn_activate = true;
		StartCoroutine (_spawn_());
		waittime = 1.5f;
	}
	
	// Update is called once per frame
		void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			PlayerPrefs.SetInt ("timesplayed", PlayerPrefs.GetInt ("timesplayed") + 1);
			PlayerPrefs.SetFloat ("TotalDist", PlayerPrefs.GetFloat ("TotalDist") + _score.score);
			PlayerPrefs.SetFloat ("LastDist", _score.score);
			if (_score.score > PlayerPrefs.GetFloat ("HighScore")) {
				PlayerPrefs.SetFloat ("HighScore", _score.score);
			}
			SceneManager.LoadScene ("menu3", LoadSceneMode.Single);
		}
		if (spawn_trees == true) {
			number_of_tree_spawn = Random.Range (1, 3);
		}
		if (spawn_activate == true) {
			number_of_spawn = Random.Range (1, 3);
		}
		if (number_of_tree_spawn > 0) {
			treespawnposition = Random.Range (0, 2);
			if (treespawnposition == 0 && !righttreeisoccupied && allclear) {
				Instantiate (tree, treeright, treerotation);
				righttreeisoccupied = true;
				spawn_trees = false;
			}
			if (treespawnposition == 1 && !lefttreeisoccupied && allclear) {
				Instantiate (tree, treeleft, treerotation);
				lefttreeisoccupied = true;
				spawn_trees = false;
			}
			number_of_tree_spawn -= 1;
		}
			if (number_of_spawn > 0) {
				spawnposition = Random.Range (0, 3);
			if (spawnposition == 0 && !rightisoccupied && allclear) {
				obstacle.gameObject.tag = "rightobstacle";
					Instantiate (obstacle, rightpos, rootsrotation);
					rightisoccupied = true;
					spawn_activate = false;
				waittime = waittime - 0.01f;
			}
			if (spawnposition == 1 && !midisoccupied && allclear) {
				obstacle.gameObject.tag = "midobstacle";
					Instantiate (obstacle, midpos, rootsrotation);
					midisoccupied = true;
					spawn_activate = false;
				waittime = waittime - 0.01f;
			}
			if (spawnposition == 2 && !leftisoccupied && allclear) {
				obstacle.gameObject.tag = "leftobstacle";
					Instantiate (obstacle, leftpos, rootsrotation);
					leftisoccupied = true;
					spawn_activate = false;
				waittime = waittime - 0.01f;
			}
				number_of_spawn -= 1;
			}
		if (waittime < 1f) {
			waittime = 1f;
		}
		}
		IEnumerator _spawn_(){
			while (true) {
			yield return new WaitForSeconds (waittime);
			allclear = true;
			//Debug.Log(Time.time+"allclear is true");
			yield return new WaitForSeconds (0.1f);
			allclear = false;
			//Debug.Log(Time.time+"allclear is false");
			}
		}
	}

		

