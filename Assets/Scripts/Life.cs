using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

	public int life;
	public PickingUp Pup;

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void FixedUpdate () {


	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag.Equals ("Ball") && Pup.lifes < 2) {

			Destroy (gameObject);
		}
	}
}
