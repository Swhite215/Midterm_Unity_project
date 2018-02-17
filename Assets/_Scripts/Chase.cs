using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {
	public Transform target;
	public float speed;
	private float step;

	void Start() {
		step = speed * Time.deltaTime;
	}

	void Update() {
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);


	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			step = 0;
			Debug.Log ("Velocity 0");

			GameManager.state = GameManager.GameState.gameover;

		}
	}

}
