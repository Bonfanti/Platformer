using UnityEngine;
using System.Collections;

public class dude : MonoBehaviour {

	public float velocity=5F;
	public Transform cam;

	private Rigidbody2D rb;
	private bool left;
	private bool right;
	private bool canJump=false;
	private float rot = 1.0F;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.fixedAngle = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("left"))
			left = true;
		if (Input.GetKeyUp ("left"))
			left = false;
		if (Input.GetKeyDown ("right"))
			right = true;
		if (Input.GetKeyUp ("right"))
			right = false;


		float vy = rb.velocity.y;
		if (left && right)
			rb.velocity = new Vector2 (0, vy);
		else if (left) {
			float halfwidth = Camera.main.aspect * Camera.main.orthographicSize;
			if (this.transform.position.x > cam.transform.position.x - halfwidth)
				rb.velocity = new Vector2 (-velocity, vy);
			else
				rb.velocity = new Vector2 (0, vy);
		}
		else if(right)rb.velocity = new Vector2 (velocity, vy);
		else rb.velocity = new Vector2 (0, vy);


		if (Input.GetKeyDown ("space") && canJump) {
			rb.velocity += new Vector2 (0, 16);
		}
		if (GetComponent<Rigidbody2D> ().position.y < -4f) {
			Application.LoadLevel("Lose");
		}

		if (rb.rotation == 10.0F || rb.rotation == -10.0F)
			rot = -rot;
		rb.rotation += rot;
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "RonaldStrump") {
			Destroy (other.gameObject);
			Application.LoadLevel("Win");

		}
		canJump = true;
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		canJump = false;
	}
}
