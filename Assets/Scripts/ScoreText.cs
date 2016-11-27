using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class ScoreText : MonoBehaviour {

	public Text scoreText;
	String score;
	// Use this for initialization
	void Start () {
		
		score = Math.Round (PickingUp.score).ToString ();
		scoreText.text = "LastScore : " + score;
		scoreText.transform.position += new Vector3 ( - (score.Length + 1) * 4, 0);
	}
	
	// Update is called once per frame
	void Update () {


	}
}
