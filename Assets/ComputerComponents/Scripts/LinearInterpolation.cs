﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour {

	public Transform startPos;
	public Transform endPos;
	public GameObject mover;

	private float timer = 0.0f;
	private GameObject objRef;
	private bool moveForward = true;

	// Use this for initialization
	void Start () {
		objRef = Instantiate (mover, startPos.position, endPos.rotation);
		
	}

	// Update is called once per frame
	void Update () {
		if (moveForward) {
			timer += Time.deltaTime;
		} else {
			timer -= Time.deltaTime;
		}
		Vector3 newPos = Vector3.zero;

		newPos = startPos.position + ((endPos.position - startPos.position) * timer);

		objRef.transform.position = newPos;

		if (timer > 1.0f) {
			timer = 1.0f;
			moveForward = false;
		}

		if (timer < 0.0f) {
			timer = 0.0f;
			moveForward = true;
		}
			
	}
}
