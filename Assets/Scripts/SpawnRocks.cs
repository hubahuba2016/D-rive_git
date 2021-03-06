using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocks : MonoBehaviour {
	public GameObject rock1;
	public GameObject rock2;
	public GameObject rock3;
	private string graphics;
	private int whichrock;
	private Quaternion rockrotation;
	private Vector3 rockposition;
	private float maxspawnyposition;
	private float minspawnyposition;
	public int number_of_spawn;
	private int maxrockspawned;
	public bool allclear;
	public bool spawn_activate;
	private float SpawnFrequency;
	private int QualityLevel;
	// Use this for initialization
	void Start () {
		graphics = PlayerPrefs.GetString ("GraphicsOption");
		if (graphics == "Very Low") {
			QualitySettings.SetQualityLevel (0);
		} else if (graphics == "Low") {
			QualitySettings.SetQualityLevel (1);
		} else if (graphics == "Medium") {
			QualitySettings.SetQualityLevel (2);
		} else if (graphics == "High") {
			QualitySettings.SetQualityLevel (3);
		} else if (graphics == "Very High") {
			QualitySettings.SetQualityLevel (4);
		} else if (graphics == "Ultra") {
			QualitySettings.SetQualityLevel (5);
		}
		QualityLevel = QualitySettings.GetQualityLevel ();
		maxrockspawned = QualityLevel + 1;
		maxspawnyposition = 95;
		minspawnyposition = 85;
		SpawnFrequency = 5 / QualityLevel;
		spawn_activate = true;
		StartCoroutine (_spawn_());
	}
	
	// Update is called once per frame
	void Update () {
		if (spawn_activate == true) {
			if (QualityLevel > 2) {
				number_of_spawn = Random.Range (0, maxrockspawned);
			}
		}
		if (number_of_spawn > 0) {
			whichrock = Random.Range (0, 3);
			if (whichrock == 0 && allclear) {
				rockrotation.eulerAngles = new Vector3(-180f, 0f, Random.Range(-180f,180f));
				rockposition = new Vector3 (Random.Range(-4.5f,4.5f),Random.Range(minspawnyposition,maxspawnyposition),-0.03f);
				Instantiate(rock1,rockposition,rockrotation);
				spawn_activate = false;
			}
			if (whichrock == 1 && allclear) {
				rockrotation.eulerAngles = new Vector3(-180f, 0f, Random.Range(-180f,180f));
				rockposition = new Vector3 (Random.Range(-4.5f,4.5f),Random.Range(minspawnyposition,maxspawnyposition),-0.01f);
				Instantiate(rock2,rockposition,rockrotation);
				spawn_activate = false;
			}
			if (whichrock == 2 && allclear) {
				rockrotation.eulerAngles = new Vector3(-180f, 0f, Random.Range(-180f,180f));
				rockposition = new Vector3 (Random.Range(-4.5f,4.5f),Random.Range(minspawnyposition,maxspawnyposition),-0.03f);
				Instantiate(rock3,rockposition,rockrotation);
				spawn_activate = false;
			}
		}
	}
	IEnumerator _spawn_(){
		while (true) {
			yield return new WaitForSeconds (SpawnFrequency);
			allclear = true;
			//Debug.Log(Time.time+"allclear is true");
			yield return new WaitForSeconds (0.05f);
			allclear = false;
			//Debug.Log(Time.time+"allclear is false");
		}
	}
}
