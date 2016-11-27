using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {


	public int scoreAmount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag.Equals ("Ball")) {

			Destroy (gameObject);
		}
	}
}
