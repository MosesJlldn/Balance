using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class PickingUp : MonoBehaviour {

	public Life Life;
	public Score Score;
	public Text scoreText;
	public Text lifesText;
	public int lifes;
	public static float score;

	// Use this for initialization
	void Start () {

		lifeCounter ();
		scoreCounter ();
		score = 500f;
	}
	// Update is called once per frame
	void Update () {

		if (score > 0) {
			score = score - Time.deltaTime;
			scoreCounter ();
		}
	}
	void OnTriggerEnter (Collider col) {

		if (col.gameObject.tag.Equals("Life")) {

			if (lifes < 2) {

				lifes += Life.life;
				lifeCounter ();
			}
		}
		if (col.gameObject.tag.Equals("Score")) {

			score += Score.scoreAmount;
			scoreCounter ();
		}
	}
	void OnTriggerExit (Collider col) {

		if (col.gameObject.tag.Equals("Ground")) {

			if (lifes > 0) {

				lifes--;
				lifeCounter ();
			} 
			if (lifes == 0){

				SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
			}
		}
	}
	void lifeCounter () {

		lifesText.text = "Lifes : " + lifes.ToString ();
	}
	void scoreCounter () {

		scoreText.text = "Score : " + Math.Round(score).ToString ();
	}
}
