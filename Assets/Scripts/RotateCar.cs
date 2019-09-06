using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCar : MonoBehaviour {
	public bool ispaused = false;
	public Quaternion rotation;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if (ispaused == false) {
			rotation.eulerAngles = new Vector3 (0f, rotation.eulerAngles.y + 2.5f, 0f);
			transform.rotation = rotation;
		}
	}
}
