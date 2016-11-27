using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Exiting : MonoBehaviour {

	public Button Exit;

	// Use this for initialization
	void Start () {
	
		Button ext = Exit.GetComponent<Button> ();
		ext.onClick.AddListener (Exitin);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Exitin () {

		Application.Quit ();
	}
}
