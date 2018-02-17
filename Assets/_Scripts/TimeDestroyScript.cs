using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyScript : MonoBehaviour {

	public float lifeTime = 10f;

	// Use this for initialization
	void Start () {
		Invoke ("DestroyObject", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyObject() {
		if (GameManager.state != GameManager.GameState.gameover) {
			Destroy (gameObject);
		}
	}
}
