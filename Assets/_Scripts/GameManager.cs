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
	public static bool pausedGame;

	// UI Elements
	public Text scoreText;
	public GameObject nextLevelTextObject;
	//pausedTextObject
	//gameOverTextObject or wonTextObject
	//play textObject probobaly a menu 
	//nextLevel or nextPhaseTextObject


	void Start () {
		state = GameState.playing;
		player = GameObject.FindGameObjectWithTag ("Player");
		//for right now until we figure out flow 
		nextLevelTextObject.SetActive (false);
		pausedGame = false;

		
	}
	
	void Update () {
		scoreText.text = "" + score;

		 //Pause Game
		if (pausedGame) { // Find mobile equivalent
			if(state == GameState.playing) {
				// Time.timeScale stops everything
				Time.timeScale = 0;
				state = GameState.paused;
			}
			// Use this code in menu to unpause game 
//			else if (state == GameState.paused) {
//				Time.timeScale = 1;
//				state = GameState.playing;
//			}
		}

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
//		nextLevelTextObject.SetActive (true);
//		SceneManager.LoadScene ("Level" + level);
//	}

	public static void PauseGame() {
		pausedGame = true;
	}

//	private void Restart() {
//		// should we ever?
//	}
}
