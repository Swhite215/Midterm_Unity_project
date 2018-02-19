using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlPowerUp : MonoBehaviour {

	private PlayerController playerController;
	public AudioClip collectWater;

	// Use this for initialization
	void Start () {
		playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			SoundManager.instance.PlaySingle (collectWater);
			playerController.SpeedPowerUp ();
			Destroy (gameObject);
		}
	}
}
