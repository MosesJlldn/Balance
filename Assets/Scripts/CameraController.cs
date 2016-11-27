using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Ball;

	// Use this for initialization
	void Start () {
		transform.position = Ball.transform.position + new Vector3 (0, 5, -5);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Ball.transform.position + new Vector3 (0, 5, -5);
	}
}
