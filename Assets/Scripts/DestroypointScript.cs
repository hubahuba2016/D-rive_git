using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroypointScript : MonoBehaviour {

	public Spawn _spawn;
	public SpawnRocks _spawnrocks;
	public GameObject scoretext;
	public GameObject world;
	void OnTriggerEnter (Collider thecollision){
		if (thecollision.gameObject.tag == "obstacle" || thecollision.gameObject.tag == "midobstacle" || thecollision.gameObject.tag == "rightobstacle" || thecollision.gameObject.tag == "leftobstacle") {
			Debug.Log("An obstacle is triggered by destroypoint");
			_spawn.spawn_activate = true;
			_spawn.rightisoccupied = false;
			_spawn.midisoccupied = false;
			_spawn.leftisoccupied = false;
			Destroy (thecollision.gameObject);
		}
		if (thecollision.gameObject.tag == "trees") {
			_spawn.spawn_trees = true;
			_spawn.righttreeisoccupied = false;
			_spawn.lefttreeisoccupied = false;
			Destroy (thecollision.gameObject);
		}
		if (thecollision.gameObject.tag == "rocks") {
			_spawnrocks.spawn_activate = true;
			Destroy (thecollision.gameObject);
		}
		if (thecollision.gameObject.tag == "coin") {
			Destroy (thecollision.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		_spawn = world.GetComponent<Spawn> ();
		_spawnrocks = world.GetComponent<SpawnRocks> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
