using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRunner : MonoBehaviour {

	public GameObject spawnPoint;
	public GameObject[] roads;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			//Pick a random number
			//Instantiate the prefab at the spawnPoint from the prefabs array.

			int randomSpawnPoint = (int)Random.Range (0, roads.Length);
			Debug.Log (randomSpawnPoint);

			Object.Instantiate (roads [randomSpawnPoint], spawnPoint.transform.position, roads[randomSpawnPoint].transform.rotation);

		}
	}
}
