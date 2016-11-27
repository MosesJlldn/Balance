using UnityEngine;
using System;
using System.Collections;

public class Teleportation : MonoBehaviour {

	public GameObject T1;
	public GameObject T2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.GetComponent<Renderer> ().sharedMaterial.name.Equals ("Wood")) {
			
			if (getDistance (col.transform.position, T1.transform.position) < 1) {
			
				col.transform.position = T2.transform.position + (T1.transform.position - col.transform.position) * -1.5f;

			} else {
				if (getDistance (col.transform.position, T2.transform.position) < 1) {
				
					col.transform.position = T1.transform.position + (T2.transform.position - col.transform.position) * -1.5f;
				}
			}
		}
		col.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		col.gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
	}

	void OnTriggerExit () {


	}

	double getDistance (Vector3 obj1, Vector3 obj2) {

		return Math.Sqrt ((obj1.x - obj2.x)*(obj1.x - obj2.x) + (obj1.z - obj2.z)*(obj1.z - obj2.z));
	}
}
