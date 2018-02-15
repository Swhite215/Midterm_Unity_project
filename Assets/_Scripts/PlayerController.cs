using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

	public float speed = 4;
	public float jumpForce = 400f;
//	public AudioClip jump;

	private Rigidbody rb;
	private bool grounded;
	private Animator anim; 

//	private Vector3 spawnPoint;


	void Start () {
//		spawnPoint = transform.position;
		rb = GetComponent<Rigidbody> ();

		anim = GetComponent <Animator> ();
		}

	void Update () {

		Debug.Log (GameManager.state);

		if (GameManager.state == GameManager.GameState.gameover) {
			anim.SetTrigger ("Dead");
		} else if (GameManager.state == GameManager.GameState.playing) {
			anim.SetTrigger ("Moving");
		}
//
//		if (GameManager.state != GameManager.GameState.playing) {
//			return;
//		}

		//MOBILE
//		float x = Input.acceleration.x;
//		float y = Input.acceleration.y;

//		Vector3 direction = new Vector3 (x, y, z);
//
//		if (direction.sqrMagnitude > 1) {
//			direction.Normalize ();
//		}

		//Desktop controls
		float x = Input.GetAxis ("Horizontal");
		rb.AddForce(transform.forward * speed);

	
		rb.velocity = new Vector3 (x * speed * Time.deltaTime, rb.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			anim.SetTrigger ("Jump");
			rb.AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
			//SoundManager.instance.PlaySingle (jump);

		}
					

		//MOBILE jump and tilt 
		//if (grounded) {
//			
////			Input.GetTouch (0);
//			SoundManage.instance.PlaySingle (jump);
//			rb.AddForce (new Vector3 (0, jumpForce));


	}

	void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "Environment") {
			grounded = true;
		}
		else {
			grounded = false;
		}
	}



//	public void Respawn () {
//
//		transform.position = spawnPoint;
//	}

}

