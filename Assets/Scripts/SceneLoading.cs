using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoading : MonoBehaviour {

	public Button TrainingLevel;

	// Use this for initialization
	void Start () {

		Button tl = TrainingLevel.GetComponent<Button> (); 

		tl.onClick.AddListener (LoadingLevel);
	}

	// Update is called once per frame
	void Update () {

	}

	void LoadingLevel () {

		SceneManager.LoadScene ("TrainingLevel", LoadSceneMode.Single);
	}
}

