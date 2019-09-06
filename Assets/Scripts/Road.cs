using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

	public GameObject road;
	private Rigidbody rb;
	private Vector3 spawnposition = new Vector3(0f,80f,0f);
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(0f,-10f);
		if (transform.position.y < -10f) {
			Instantiate (road, spawnposition, transform.rotation);
			Destroy (this.gameObject);
		}
	}
}
