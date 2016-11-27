using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public int speed;
	private bool teleported;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical   = Input.GetAxis("Vertical");

		Vector3 position = transform.position;

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed, ForceMode.Force);
	}
}
