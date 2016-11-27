using UnityEngine;
using System.Collections;
using System;

public class Hover : MonoBehaviour {


	private Rigidbody rb;
	bool isHovering;
	double distance;
	Vector3 hover;
	Vector3 ball;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		ball = transform.position;

		distance = getDistance(ball, hover);
	}


	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag.Equals ("Hover")) {
			
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 2.5f, ForceMode.Impulse);
			hover = col.transform.position;
		}
	}

	void OnTriggerStay (Collider col) {

		if (col.gameObject.tag.Equals ("Hover")) {
			
			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 1, ForceMode.Impulse);
		}
	}

	void OnTriggerExit (Collider col) {

		if (col.gameObject.tag.Equals ("Hover") && Math.Abs(getDistance(ball, hover)) < 0.5) {

			gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * 10, ForceMode.Impulse);
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		}
	}

	double getDistance(Vector3 obj1, Vector3 obj2) {

		return Math.Sqrt ((obj1.x - obj2.x)*(obj1.x - obj2.x) + (obj1.z - obj2.z)*(obj1.z - obj2.z));
	}
}
