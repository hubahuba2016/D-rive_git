using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour {
	private Rigidbody rb;
	public GameObject World;
	public Score _score;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		World = GameObject.Find ("World");
		_score = World.GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_score.gameover == false) {
			rb.velocity = new Vector3 (0f, -10f, 0f);
		} else {
			rb.velocity = new Vector3 (0f, 0f, 0f);
		}
	}
}
