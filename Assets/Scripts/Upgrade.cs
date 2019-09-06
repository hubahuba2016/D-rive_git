using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Upgrade : MonoBehaviour {


	public void UpgradeOnClick(){
		SceneManager.LoadScene ("upgrade", LoadSceneMode.Single);
	}
}
