using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckPointPassing : MonoBehaviour {

	public bool passed;
	public Text message;

	// Use this for initialization
	void Start () {

		passed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {

		if (col.CompareTag ("Ball") && !passed) {

			passed = true;
			message.gameObject.SetActive (true);
		}
	}

	void OnTriggerExit (Collider col) {

		if (col.CompareTag ("Ball")) {
			
			message.gameObject.SetActive (false);
		}
	}
}
