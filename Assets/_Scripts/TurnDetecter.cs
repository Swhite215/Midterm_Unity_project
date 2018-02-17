using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnDetecter : MonoBehaviour {


	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			PlayerController.canTurn = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag == "Player") {
			PlayerController.canTurn = false;
		}
	}
}
