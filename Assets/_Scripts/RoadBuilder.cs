using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBuilder : MonoBehaviour {

	public enum Direction { North, South, East, West};

	public GameObject spawnPoint;
	public GameObject[] roads;

	private float rightRotation;
	private float leftRotation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {

			int roadToSpawn = (int)Random.Range (0, roads.Length);
			Debug.Log (roadToSpawn);

			if (roadToSpawn >= 0 && roadToSpawn <= 2) {
				Object.Instantiate (roads [roadToSpawn], spawnPoint.transform.position, spawnPoint.transform.rotation);
			} else if (roadToSpawn >= 3 && roadToSpawn <= 5) {
				Quaternion newAngle = Quaternion.Euler (0, spawnPoint.transform.rotation.eulerAngles.y - 90, 0);
				Object.Instantiate (roads [roadToSpawn], spawnPoint.transform.position, newAngle);
			} else {
				Quaternion newAngle = Quaternion.Euler (0, spawnPoint.transform.rotation.eulerAngles.y + 90, 0);
				Object.Instantiate (roads [roadToSpawn], spawnPoint.transform.position, newAngle);
			}

		}
	}
}
