using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenuScript : MonoBehaviour {
private AudioClip RD;
public AudioSource Red_Direction;
	// Use this for initialization
	void Start () {
		Red_Direction = this.gameObject.GetComponent<AudioSource>();
		RD = Red_Direction.GetComponent<AudioClip>();
		Red_Direction.loop = true;
		Red_Direction.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
