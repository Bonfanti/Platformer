using UnityEngine;
using System.Collections;

public class dude : MonoBehaviour {

	public float velocity=5F;

	private Rigidbody2D rb;
	private bool left;
	private bool right;
	private bool canJump=false;
	private int jumpCount;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

		jumpCount = 0;
	
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
		if (left && right) rb.velocity = new Vector2 (0, vy);
		else if(left)rb.velocity = new Vector2 (-velocity, vy);
		else if(right)rb.velocity = new Vector2 (velocity, vy);
		else rb.velocity = new Vector2 (0, vy);


		if (Input.GetKeyDown ("space") && canJump && jumpCount < 2) {
			if(jumpCount == 0)rb.velocity += new Vector2 (0, 8);
			else rb.velocity += new Vector2 (0, 16);
			jumpCount++;
		}
		if (GetComponent<Rigidbody2D> ().position.y < -4f) {
			Application.LoadLevel("Lose");
		}
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "RonaldStrump") {
			Destroy (other.gameObject);
			Application.LoadLevel("Win");

		}
		canJump = true;
		jumpCount = 0;
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		canJump = false;
	}
}
