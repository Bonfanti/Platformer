using UnityEngine;
using System.Collections;

public class followCastle : MonoBehaviour {

	public Transform target;
	public float velocity;
	private Transform cam;
	private float cy=0;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		//print (target.position);
		//print (camera.position );
		float y = target.position.y;
		float halfheight = Camera.main.orthographicSize;
		if (y < cam.position.y - halfheight*1/8)cy -= velocity;
		if(y > cam.position.y + halfheight*1/8)cy+=velocity; //0.2F is recommended

		cam.position = new Vector3(cam.position.x,cy,-20);
	}
}
