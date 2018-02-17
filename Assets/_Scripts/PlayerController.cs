using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public Vector3 moveDirection;
	public static bool canTurn;

//	public AudioClip jump;

	private Rigidbody rb;
	private bool grounded;
	private Animator anim; 

//	
//	private Vector3 spawnPoint;


	void Start () {
//		spawnPoint = transform.position;
		moveDirection = transform.forward;
		Debug.Log (moveDirection);
		canTurn = false;

		rb = GetComponent<Rigidbody> ();
		anim = GetComponent <Animator> ();
	}



	void Update () {

		Debug.Log (GameManager.state);

		if (GameManager.state == GameManager.GameState.gameover) {
			anim.SetTrigger ("Cry");
			moveDirection = Vector3.zero; 


		} else if (GameManager.state == GameManager.GameState.playing) {
			anim.SetTrigger ("Moving");
		}
//
//		if (GameManager.state != GameManager.GameState.playing) {
//			return;
//		}


		PlayerMovement ();

	}
	// change powerups to enum and switch statements 
	public void JumpPowerUp() {
		jumpForce += 1f;
	}

	public void SpeedPowerUp() {
		speed += 20f;
	}


	//	public void Respawn () {
	//
	//		transform.position = spawnPoint;
	//	}



	void OnCollisionEnter(Collision other) {
		if(other.collider.tag == "Environment") {
			grounded = true;
		}
		else {
			grounded = false;
		}
	}


	void PlayerMovement() {
		//MOBILE
		//		float x = Input.acceleration.x;
		//		float y = Input.acceleration.y;

		//		Vector3 direction = new Vector3 (x, y, z);
		//
		//		if (direction.sqrMagnitude > 1) {
		//			direction.Normalize ();
		//		}

		float x = Input.GetAxis ("Horizontal");
		rb.AddForce(moveDirection * speed * Time.deltaTime);

		transform.Translate (new Vector3 (x * 5 * Time.deltaTime, 0, 0));

		//rb.velocity = new Vector3 (x * speed * Time.deltaTime, rb.velocity.y, 0);
		// to get him to hop in circle s
		//		rb.velocity = new Vector3 (xVel, yVel, zVel);

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			anim.SetTrigger ("Jump");
			rb.AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
			//SoundManager.instance.PlaySingle (jump);
		}
		if (Input.GetKeyDown ("a") && canTurn) { 
			transform.Rotate (0, -90, 0);
			moveDirection = transform.forward;
			canTurn = false;
			}

		if (Input.GetKeyDown ("d") && canTurn) {
			transform.Rotate (0, 90, 0);
			moveDirection = transform.forward;
			canTurn = false;
			}
		






		//MOBILE jump and tilt 
		//if (grounded) {
		//			
		////			Input.GetTouch (0);
		//			SoundManage.instance.PlaySingle (jump);
		//			rb.AddForce (new Vector3 (0, jumpForce));
	}




}

