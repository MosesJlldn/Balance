using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject spawn1;
	public GameObject spawn2;
	public CheckPointPassing cpp1;
	public CheckPointPassing cpp2;
	bool passed1;
	bool passed2;
	bool[] cpps;
	GameObject[] spawns;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		passed1 = cpp1.passed;
		passed2 = cpp2.passed;
		cpps = new bool[2] {passed1, passed2};
		spawns = new GameObject[2] {spawn1, spawn2};
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit (Collider col) {
			
		if (col.gameObject.tag.Equals ("Ground")) {

			cpps = new bool[2] {cpp1.passed, cpp2.passed};
			for (int i = 1; i >= 0; i--) {

				if (cpps [i]) {

					transform.position = spawns [i].transform.position + Vector3.up * 0.5f;
					rb.angularVelocity = Vector3.zero;
					rb.velocity = Vector3.zero;
					break;
				}
			}
		}
	}
}
