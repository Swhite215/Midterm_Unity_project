using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockOut : MonoBehaviour {

	public AudioClip knockOut;

	void OnCollisionEnter(Collision other) {
		if (other.collider.tag == "Player") {
			SoundManager.instance.PlaySingle (knockOut);
			GameManager.state = GameManager.GameState.gameover;
		}
	}
}
