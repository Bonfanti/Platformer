using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {

	public Transform target;
	public float velocity;
	private Transform cam;
	private float cx=0;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//print (target.position);
		//print (camera.position );
		float x = target.position.x;
		float halfwidth = Camera.main.aspect * Camera.main.orthographicSize;
		if (x < cam.position.x - halfwidth*1/8)cx -= velocity;
		if(x > cam.position.x + halfwidth*1/8)cx+=velocity; //0.3F is recommended

		if (target.position.y < -15f) cx = 11.7F;

		cam.position = new Vector3(cx,cam.position.y,-10);
	}
}
