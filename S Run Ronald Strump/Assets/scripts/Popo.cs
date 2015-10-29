using UnityEngine;
using System.Collections;

public class Popo : MonoBehaviour {

	public uint velocity;

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time % 2.0 < 1.0F) {
			rb.velocity = new Vector2 (velocity, 0);
		} else
			rb.velocity = new Vector2 (-velocity, 0);
	}
}
