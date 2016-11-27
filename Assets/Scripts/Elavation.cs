using UnityEngine;
using System.Collections;
using System;

public class Elavation : MonoBehaviour {


	public GameObject A;
	public GameObject B;
	public Pressing pressing;
	bool isPressed;
	public bool destination;
	private Rigidbody rb;
	float wait = 0;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {

		isPressed = pressing.isPressed;

		if (isPressed) {

			if (Vector3.Distance (transform.position, A.transform.position) < 1f || Vector3.Distance (transform.position, B.transform.position) < 1f) {

				wait += Time.deltaTime;
			}
				
			if (wait > 5) {
				
				if (destination) {
						
					transform.position = transform.position + Vector3.up * Time.deltaTime;
				} else {
						
					transform.position = transform.position + Vector3.down * Time.deltaTime;
				}
			}
		}
	}
	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag.Equals ("Destination")) {

			destination = !destination;
			wait = 0;
		}
	}
}
	