using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	public int points;
//	public AudioClip collect;

	void OnCollisionEnter(Collision other) {
		if (other.collider.tag == "Player") {
//			SoundManager.instance.PlaySingle (collect);
			GameManager.AddScore (points);
			Destroy (this.gameObject);
		}
	}
}
