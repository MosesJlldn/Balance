using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level1 : MonoBehaviour {

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

