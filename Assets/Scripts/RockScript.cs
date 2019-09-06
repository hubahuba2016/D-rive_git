﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour {
	private Rigidbody rb;
	public GameObject World;
	public GameObject player;
	public Score _score;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		World = GameObject.Find ("World");
		_score = World.GetComponent<Score> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		if (_score.gameover == false) {
			rb.velocity = new Vector3 (0f, -10f, 0f);
			if (transform.position.y < player.transform.position.y) {
				PlayerPrefs.SetInt ("TotalRocks", PlayerPrefs.GetInt ("TotalRocks") + 1);
			}
		} else {
			rb.velocity = new Vector3 (0f, 0f, 0f);
		}
	}
}
