using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public bool teleported;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {

		teleported = true;
	}

	void OnTriggerExit (Collider col) {

		teleported = false;
	}
}
