using UnityEngine;
using System.Collections;

public class Transformation : MonoBehaviour {

	public Transformer tr;
	public float mass;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		mass = gameObject.GetComponent<Rigidbody> ().mass;
	}

	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag.Equals("Wood") && !gameObject.GetComponent<Renderer>().sharedMaterial.name.Equals("Wood")) {

			gameObject.GetComponent<Rigidbody> ().mass = tr.woodMass;
			gameObject.GetComponent<Renderer>  ().material = tr.woodMat;
			gameObject.transform.position = col.transform.position;
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		}
		if (col.gameObject.tag.Equals("Stone") && !gameObject.GetComponent<Renderer>().sharedMaterial.name.Equals("Stone")) {

			gameObject.GetComponent<Rigidbody> ().mass = tr.stoneMass;
			gameObject.GetComponent<Renderer>  ().material = tr.stoneMat;
			gameObject.transform.position = col.transform.position;
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		}
		if (col.gameObject.tag.Equals("Paper") && !gameObject.GetComponent<Renderer>().sharedMaterial.name.Equals("Paper")) {

			gameObject.GetComponent<Rigidbody> ().mass = tr.paperMass;
			gameObject.GetComponent<Renderer>  ().material = tr.paperMat;
			gameObject.transform.position = col.transform.position;
			gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			gameObject.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
		}		
	}
}
