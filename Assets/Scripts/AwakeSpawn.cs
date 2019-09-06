using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeSpawn : MonoBehaviour {
	public GameObject obstacle;
	public GameObject tree;
	private int i;
	private int j;
	public float[] objectset;
	private bool destroyscript;
	private Quaternion obstaclerotation;
	private Quaternion treerotation;
	private AwakeSpawn _awakescript;
	public int number_of_spawn;
	public int number_of_tree_spawn;
	public bool spawn_activate = true;
	public bool spawn_trees = true;
	private int spawnposition;
	private int treespawnposition;
	public bool rightisoccupied;
	public bool midisoccupied;
	public bool leftisoccupied;
	public bool righttreeisoccupied;
	public bool lefttreeisoccupied;
	private Vector3 rightpos;
	private Vector3 midpos;
	private Vector3 leftpos;
	private Vector3 treeright;
	private Vector3 treeleft;
	public bool allgo;
	// Use this for initialization
	void Awake () {
		obstaclerotation.eulerAngles = new Vector3 (0f, 180f, 90f);
		treerotation.eulerAngles = new Vector3 (-180f, 0f, 0f);
		rightpos = new Vector3(2.5f,80f,-0.06f);
		midpos = new Vector3 (0f,80f,-0.06f);
		leftpos = new Vector3 (-2.5f,80f,-0.06f);
		treeright = new Vector3 (6.07f, 80f, 0.06f);
		treeleft = new Vector3 (-5.83f, 80f, 0.06f);
		_awakescript = GetComponent<AwakeSpawn> ();
		objectset = new float[14];
		for (j = 0; j <= 13; j++) {
			objectset [j] = (6*j)+8;
			if (spawn_trees == true) {
				number_of_tree_spawn = Random.Range (1, 3);
			}
			if (spawn_activate == true) {
				number_of_spawn = Random.Range (1, 3);
			}
			if (number_of_tree_spawn > 0) {
				treespawnposition = Random.Range (0, 2);
				if (treespawnposition == 0 && !righttreeisoccupied) {
					Instantiate (tree, new Vector3 (treeright.x,objectset[j],treeright.z), treerotation);
					righttreeisoccupied = true;
					spawn_trees = false;
				}
				if (treespawnposition == 1 && !lefttreeisoccupied) {
					Instantiate (tree, new Vector3 (treeleft.x,objectset[j],treeleft.z), treerotation);
					lefttreeisoccupied = true;
					spawn_trees = false;
				}
				number_of_tree_spawn -= 1;
			}
			if (number_of_spawn > 0) {
				spawnposition = Random.Range (0, 3);
				if (spawnposition == 0&&!rightisoccupied) {
					Instantiate(obstacle,new Vector3(rightpos.x,objectset[j],rightpos.z),obstaclerotation);
					rightisoccupied = true;
					spawn_activate = false;
				}
				if(spawnposition == 1&&!midisoccupied) {
					Instantiate(obstacle,new Vector3(midpos.x,objectset[j],midpos.z),obstaclerotation);
					midisoccupied = true;
					spawn_activate = false;
				}
				if(spawnposition == 2&&!leftisoccupied) {
					Instantiate(obstacle,new Vector3(leftpos.x,objectset[j],leftpos.z),obstaclerotation);
					leftisoccupied = true;
					spawn_activate = false;
				}
				number_of_spawn -= 1;
			}
			righttreeisoccupied = false;
			lefttreeisoccupied = false;
			rightisoccupied = false;
			midisoccupied = false;
			leftisoccupied = false;
			spawn_trees = true;
			spawn_activate = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		

		if (j == 13) {
			allgo = true;
			destroyscript = true;
		}
		if (destroyscript == true) {
			Destroy (_awakescript);
		}
		
	}
}
