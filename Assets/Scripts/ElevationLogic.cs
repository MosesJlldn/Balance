using UnityEngine;
using System.Collections;

public class ElevationLogic : MonoBehaviour {


	private Rigidbody rb;
	private float forceValue;
	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
		forceValue = 0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		rb.AddForce (Vector3.up * forceValue, ForceMode.Impulse);
	}

	void OnTriggerEnter (Collider col) {

		if (col.CompareTag ("Destination")) {

			forceValue = 0;
			rb.constraints = RigidbodyConstraints.FreezeAll;
		}
		if (col.CompareTag ("Ball")) {

			forceValue = 2;
		}
	}
}
