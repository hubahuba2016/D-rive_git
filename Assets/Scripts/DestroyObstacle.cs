using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour {
	private Rigidbody rb;
	public GameObject player;
	public GameObject scoretext;
	public Score _score;
	public GameObject world;
	public float spawn;
	public GameObject[] rightobstacles;
	public GameObject[] midobstacles;
	public GameObject[] leftobstacles;
	public GameObject rightobstacleinrow;
	public GameObject midobstacleinrow;
	public GameObject leftobstacleinrow;
	int r;
	int m;
	int l;
	int destroyobstacle = 0;
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Player") {
			_score.gameover = true;
			Debug.Log ("Game over");
		}
	}
	void Start(){
		rb = this.GetComponent<Rigidbody> ();
		player = GameObject.FindGameObjectWithTag("Player");
		scoretext = GameObject.Find ("World");
		world = GameObject.Find ("World");
		_score = scoretext.GetComponent<Score> ();
		rightobstacles = GameObject.FindGameObjectsWithTag ("rightobstacle");
		midobstacles = GameObject.FindGameObjectsWithTag ("midobstacle");
		leftobstacles = GameObject.FindGameObjectsWithTag ("leftobstacle");
		for (r = 0; r < rightobstacles.Length; r++) {
			if ((rightobstacles [r].transform.position.y > (transform.position.y - 3f)) && (rightobstacles [r].transform.position.y < (transform.position.y + 3f))) {
				rightobstacleinrow = rightobstacles [r];
			}
		}
		for (m = 0; m < midobstacles.Length; m++) {
			if ((midobstacles [m].transform.position.y > (transform.position.y - 3f)) && (midobstacles [m].transform.position.y < (transform.position.y + 3f))) {
				midobstacleinrow = midobstacles [m];
			}
		}
		for (l = 0; l < leftobstacles.Length; l++) {
			if ((leftobstacles[l].transform.position.y > (transform.position.y - 3f)) && (leftobstacles [l].transform.position.y < (transform.position.y + 3f))) {
				leftobstacleinrow = leftobstacles [l];
			}
		}
		}
	void Update() {
		if (_score.gameover == false) {
			rb.velocity = new Vector2 (0f, -10f);
		} else {
			rb.velocity = new Vector2 (0f, 0f);
		}
		if (transform.position.x < 3) {
			if (this.gameObject.tag == "rightobstacle") {
				rightobstacleinrow = this.gameObject;
			} else if (this.gameObject.tag == "midobstacle") {
				midobstacleinrow = this.gameObject;
			} else if(this.gameObject.tag == "leftobstacle"){
				leftobstacleinrow = this.gameObject;
			}
		}
		if ((rightobstacleinrow.activeInHierarchy == true) && (midobstacleinrow.activeInHierarchy == true) && (leftobstacleinrow.activeInHierarchy == true)) {
			destroyobstacle = Random.Range (1, 4);
		}
		if (destroyobstacle == 1) {
			Destroy (rightobstacleinrow.gameObject);
			destroyobstacle = 4;
		} else if (destroyobstacle == 2) {
			Destroy (midobstacleinrow.gameObject);
			destroyobstacle = 4;
		} else if (destroyobstacle == 3) {
			Destroy (leftobstacleinrow.gameObject);
			destroyobstacle = 4;
		}
	}
}