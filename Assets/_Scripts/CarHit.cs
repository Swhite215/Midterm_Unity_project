using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHit : MonoBehaviour {

	public AudioClip carHorn;

	void OnCollisionEnter(Collision other) {
		if (other.collider.tag == "Player") {
			SoundManager.instance.PlaySingle (carHorn);
			GameManager.state = GameManager.GameState.gameover;
		}
	}
}
