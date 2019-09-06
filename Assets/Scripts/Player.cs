using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	Vector2 deltaswipe;
	Vector2 touchposition;
	private bool swiperight;
	private bool swipeleft;
	private bool midpos;
	private bool rightpos;
	private bool leftpos;
	private Vector3 newposition;
    Vector3 midposition;
	Vector3 rightposition;
	Vector3 leftposition;
	// Use this for initialization
	void Start () {
		midpos = true;
		if (PlayerPrefs.GetInt ("carequipped") == 1) {
			midposition = new Vector3 (0f, -3.58f, 0f);
			rightposition = new Vector3 (2f, -3.58f, 0f);
			leftposition = new Vector3 (-2f, -3.58f, 0f);
			newposition = new Vector3 (0f, -3.58f, 0f);
		} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
			midposition = new Vector3 (0f, -3.58f, -0.39f);
			rightposition = new Vector3 (2f, -3.58f, -0.39f);
			leftposition = new Vector3 (-2f, -3.58f, -0.39f);
			newposition = new Vector3 (0f, -3.58f, -0.39f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			touchposition = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp (0)) {
			deltaswipe.x = touchposition.x - Input.mousePosition.x;
			if (deltaswipe.x < 0) {
				swiperight = true;
			}
			if (deltaswipe.x > 0) {
				swipeleft = true;
			}
		}

		if(swiperight){
			if(midpos == true){
				newposition = rightposition;
				rightpos = true;
				midpos = false;
				swiperight = false;
			}
			if (leftpos == true) {
				newposition = midposition;
				midpos = true;
				leftpos = false;
				swiperight = false;
			}
		}
		if (swipeleft) {
			if (rightpos == true) {
				newposition = midposition;
				midpos = true;
				rightpos = false;
				swipeleft = false;
			}
			else if (midpos == true) {
				newposition = leftposition;
				leftpos = true;
				midpos = false;
				swipeleft = false;
			}
		}
		if (PlayerPrefs.GetInt ("carequipped") == 1) {
			transform.position = Vector3.Lerp (transform.position, newposition, Time.deltaTime * 10f);
		} else if (PlayerPrefs.GetInt ("carequipped") == 2) {
			transform.position = Vector3.Lerp (transform.position, newposition, Time.deltaTime * 15f);
		}
	}
}

