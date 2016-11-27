using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GoToMainMenu : MonoBehaviour {

	// Use this for initialization
	public Button level1;

	// Use this for initialization
	void Start () {

		Button lvl1 = level1.GetComponent<Button> (); 

		lvl1.onClick.AddListener (LoadingLevel);
	}

	// Update is called once per frame
	void Update () {

	}

	void LoadingLevel () {

		SceneManager.LoadScene ("level1", LoadSceneMode.Single);
	}
}
