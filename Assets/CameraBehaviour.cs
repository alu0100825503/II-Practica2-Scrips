﻿using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		
	public float speedH = 10000.0f;
	public float speedV = 10000.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Update() {
		yaw += speedH * Input.GetAxis ("Mouse X");
		pitch -= speedV * Input.GetAxis ("Mouse Y");
		transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
	}
}
