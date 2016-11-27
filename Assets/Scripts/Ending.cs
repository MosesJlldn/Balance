using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ending : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {

		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
	}
}
