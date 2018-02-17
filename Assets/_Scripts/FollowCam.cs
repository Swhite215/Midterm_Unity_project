using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
	public Transform target;

	public Vector3 offsetPosition;

	private Space offsetPositionSpace = Space.Self;
	private bool lookAt = true;

	void LateUpdate () {
		Refresh ();
	}

	public void Refresh() {
		if (target == null) {
			Debug.Log ("Missing Player Transform");
			return;
		}
		// POSITION
		if(offsetPositionSpace == Space.Self) {
			transform.position = target.TransformPoint (offsetPosition);
		}
		else {
			transform.position = target.position + offsetPosition;
		}
		 //ROTATION
		if(lookAt) {
			transform.LookAt (target);
		}
		else {
			transform.rotation = target.rotation;
		}
	}


}
