﻿using System.Collections;
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
		jumpForce += 10f;
	}

	public void SpeedPowerUp() {
		speed += 10f;
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

<<<<<<< HEAD
	public void jumpPowerUp() {
		jumpForce += 1f;
	}

	public void speedPowerUp() {
		speed += 20f;
=======





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
		rb.AddForce(moveDirection * speed);


		rb.velocity = new Vector3 (x * speed * Time.deltaTime, rb.velocity.y);
		// to get him to hop in circle s
		//		rb.velocity = new Vector3 (xVel, yVel, zVel);

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			anim.SetTrigger ("Jump");
			rb.AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
			//SoundManager.instance.PlaySingle (jump);
		}
		if (Input.GetKeyDown ("a") && canTurn) { 
			transform.Rotate (0, -90, 0);
			moveDirection = Quaternion.AngleAxis (-90, Vector3.up) * moveDirection;
			canTurn = false;
			}

		if (Input.GetKeyDown ("d") && canTurn) { 
			transform.Rotate (0, 90, 0);
			moveDirection = Quaternion.AngleAxis (90, Vector3.up) * moveDirection;
			canTurn = false;
			}
		






		//MOBILE jump and tilt 
		//if (grounded) {
		//			
		////			Input.GetTouch (0);
		//			SoundManage.instance.PlaySingle (jump);
		//			rb.AddForce (new Vector3 (0, jumpForce));
>>>>>>> 4e1733d7e3d182cf1b82ccd3f75c09afb03be34d
	}




}

