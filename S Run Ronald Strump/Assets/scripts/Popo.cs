using UnityEngine;
using System.Collections;

public class Popo : MonoBehaviour {

	public uint velocity;

	private float time = 0.0F, deathClock;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		deathClock = velocity >= 20 ? 0.3F : 0.2F;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time % 2.0 < 1.0F) {
			rb.velocity = new Vector2 (velocity, 0);
		} else
			rb.velocity = new Vector2 (-velocity, 0);
		if (time != 0.0F && Time.time - time > (velocity >= 20 ? 0.3F : 0.2F))
			Application.LoadLevel ("lose");
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			time = Time.time;
			print ("lel");
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") {
			time = 0.0F;
		}
	}
}
