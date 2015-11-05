using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	public GameObject martin;
	public GameObject mrsStrump;
	public GameObject strumpFire;
	public Sprite sadMartin, slinkton, police, candles, houses, strumps;
	public Camera cam;

	// Use this for initialization
	void Start () {
		strumpFire.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") || Input.GetMouseButtonDown (0))
			Application.LoadLevel ("game");
		float time = Time.timeSinceLevelLoad;
		if (time > 4.0F && time < 4.5F) {
			mrsStrump.transform.position = new Vector3(-13, 0, -5);
		}
		if (time > 4.5F && time < 4.6F) {
			mrsStrump.transform.position = new Vector3(-13, -1, -5);
		}
		if (time > 17.2F && time < 17.7F) {
			martin.transform.position = new Vector3(-11, 0, -5);
		}
		if (time > 17.7F && time < 17.8F) {
			martin.transform.position = new Vector3(-11, -1, -5);
		}
		if (time > 18.5F && time < 18.6F) {
			cam.transform.position = new Vector3(-4, 0, -10);
		}
		if (time > 18.6F && time < 18.7F) {
			martin.GetComponent<Rigidbody2D>().velocity = new Vector2(11, 0);
			martin.GetComponent<SpriteRenderer>().sprite = sadMartin;
		}
		if (time > 20.0F && time < 20.1F) {
			martin.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
			martin.transform.position = new Vector3(5.8F, -2, -5);
		}
		if (time > 33.0F && time < 33.1F) {
			strumpFire.GetComponent<SpriteRenderer>().enabled = true;
		}
		if (time > 35.0F && time < 35.1F) {
			strumpFire.GetComponent<SpriteRenderer>().sprite = slinkton;
		}
		if (time > 37.7F && time < 37.8F) {
			strumpFire.GetComponent<SpriteRenderer>().sprite = police;
		}
		if (time > 39.2F && time < 39.3F) {
			strumpFire.GetComponent<SpriteRenderer>().sprite = candles;
		}
		if (time > 41.0F && time < 41.1F) {
			strumpFire.GetComponent<SpriteRenderer>().sprite = houses;
		}
		if (time > 42.5F && time < 42.6F) {
			strumpFire.GetComponent<SpriteRenderer>().sprite = strumps;
		}
		if (time > 43.5F && time < 43.6F) {
			strumpFire.GetComponent<SpriteRenderer>().enabled = false;
		}
		if (time > 51.5F)
			Application.LoadLevel ("game");

	}
}
