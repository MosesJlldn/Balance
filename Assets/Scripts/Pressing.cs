using UnityEngine;
using System.Collections;

public class Pressing : MonoBehaviour {

	public bool isPressed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.GetComponent<Renderer>().sharedMaterial.name.Equals("Stone") && !isPressed) {
			
			transform.position += new Vector3 (0, -0.05f, 0);
			isPressed = true;
		}
	}
}
