﻿using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public Transform target;
	private Transform camera;
	private float cx=0;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Transform> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//print (target.position);
		//print (camera.position );
		float x = target.position.x;
		float halfwidth = Camera.main.aspect * Camera.main.orthographicSize;
		if (x < camera.position.x - halfwidth*7/8)
			cx -= .1F;
		if(x > camera.position.x)cx+=.1F;

		camera.position = new Vector3(cx,camera.position.y,-10);
	
	}
}
