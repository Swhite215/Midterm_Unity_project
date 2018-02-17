using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public enum GameState { menu, playing, paused, gameover };

	public static int level = 1;
	public static int score = 0;
	public static GameState state;
	public static GameObject player;

	// UI Elements
	//score text 
	//level/progression text
	//pausedTextObject
	//gameOverTextObject or wonTextObject
	//play textObject probobaly a menu 
	//nextLevel or nextPhaseTextObject


	void Start () {
		state = GameState.playing;
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	void Update () {
//		scoreText.text = "" + score;

		// Pause Game
//		if (Input.GetKeyDown ( (KeyCode.Escape))) { // Find mobile equivalent
//			if(state == GameState.playing) {
//				// Time.timeScale stops everything
//				Time.timeScale = 0;
//				state = GameState.paused;
//			}
//			else if (state == GameState.paused) {
//				Time.timeScale = 1;
//				state = GameState.playing;
//			}
//		}

//		if (state == GameState.playing) {
//			// Set text objects .SetActive to false
//		}
//		else if (state == GameState.paused) {
//			// set pausedTextObject.SetActive(true);
//		}
//		else if (state == GameState.gameover) {
			// game or won TextObject SetActive to true
			//restartText Set Active to true
//			if (Input.GetKeyDown(KeyCode.R)) { // find mobile equivalent/or just show button on menu
//				Restart ();
//			}
//		}
	}

	public static void AddScore(int points) {
		score += points;
		Debug.Log (score);
	}

	public static void KnockOut () {

		// player animation goes here? 

		player.SendMessage ("Respawn");

		Camera.main.transform.position = new Vector3 (
			player.transform.position.x,
			player.transform.position.y,
			Camera.main.transform.position.z
		);
	}

//	public static void NextLevel () {
//		level++;
//		// When to do this?
//		SceneManager.LoadScene ("Level" + level);
//	}

//	private void Restart() {
//		// should we ever?
//	}
}
