﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureWalk : MonoBehaviour {
	private HeadLookWalk lookWalk;  
	private HeadGesture gesture;

	void Start () {
		lookWalk = GetComponent<HeadLookWalk> ();    
		gesture = GameObject.Find ("GameController"). GetComponent<HeadGesture> ();
	}

	void Update () {
		if (gesture.isMovingDown) {      
			lookWalk.isWalking = !lookWalk.isWalking;    
		} 
	}
}
