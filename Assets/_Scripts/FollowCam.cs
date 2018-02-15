using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
	private Vector3 offset;
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
		offset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			transform.position = player.transform.position + offset;
		}
	}
}
