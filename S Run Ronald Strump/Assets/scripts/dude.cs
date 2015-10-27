using UnityEngine;
using System.Collections;

public class dude : MonoBehaviour {

	public float velocity, jumpVelocity;
	public Transform cam;
	public Sprite orig, fist;

	private Rigidbody2D rb;
	private bool left, a;
	private bool right, d;
	private bool canJump=false;
	private float rot = 1.0F;
	private Vector3 startPos;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.fixedAngle = true;
		startPos = rb.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("a"))
			a = true;
		if (Input.GetKeyUp ("a"))
			a = false;
		if (Input.GetKeyDown ("d"))
			d = true;
		if (Input.GetKeyUp ("d"))
			d = false;
		if (Input.GetKeyDown ("left"))
			left = true;
		if (Input.GetKeyUp ("left"))
			left = false;
		if (Input.GetKeyDown ("right"))
			right = true;
		if (Input.GetKeyUp ("right"))
			right = false;


		float vy = rb.velocity.y;
		if ((left && right) || (a && d) || (left && d) || (right && a))
			rb.velocity = new Vector2 (0, vy);
		else if (left || a) rb.velocity = new Vector2 (-velocity, vy);
		else if(right || d)rb.velocity = new Vector2 (velocity, vy);
		else rb.velocity = new Vector2 (0, vy);


		if (Input.GetKeyDown ("space") && canJump) {
			rb.velocity += new Vector2 (0, jumpVelocity);
		}
		//if (rb.position.y < -15f) {
			//rb.position = new Vector3(6.89F, 0.34F, 0);
		//}
		//print(canJump);
		if (rb.rotation == 10.0F || rb.rotation == -10.0F)
			rot = -rot;
		rb.rotation += rot;

		if (Input.GetKeyDown ("x")) {
			GetComponent<SpriteRenderer>().sprite = fist;
		}
		if (Input.GetKeyUp ("x")) {
			GetComponent<SpriteRenderer> ().sprite = orig;
		}
		if (GetComponent<Rigidbody2D> ().position.y < -15f) {
			Application.LoadLevel("Lose");
			//rb.position = startPos;
		}
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "RonaldStrump") {
			Destroy (other.gameObject);
			Application.LoadLevel("Win");

		}
		else if(other.transform.position.y < this.transform.position.y - 1.83F) canJump = true;
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		canJump = false;
	}
}
