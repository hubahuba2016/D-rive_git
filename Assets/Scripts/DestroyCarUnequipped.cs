using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCarUnequipped : MonoBehaviour {
	public GameObject car1;
	public GameObject car2;
	public SyncColor _synccolor;
	private DestroyCarUnequipped _destroycar;

	void Awake(){
		_synccolor = GetComponent<SyncColor> ();
	}
	void Start(){
		_synccolor.sync ();
		if (PlayerPrefs.GetInt ("carequipped",1) == 1) {
			Destroy (car2.gameObject);
		} else if (PlayerPrefs.GetInt ("carequipped",1) == 2) {
			Destroy (car1.gameObject);
		}
		Destroy (_synccolor);
		Destroy (_destroycar);
	}
}
