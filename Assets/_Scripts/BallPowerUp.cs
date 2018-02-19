using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPowerUp : MonoBehaviour {

	private PlayerController playerController;
	public AudioClip collectBall;

	// Use this for initialization
	void Start () {
		playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			SoundManager.instance.PlaySingle (collectBall);
			playerController.JumpPowerUp ();
			Destroy (this.gameObject);
		}
	}
}
