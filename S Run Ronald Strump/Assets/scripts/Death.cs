using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public Rigidbody2D weapon;
	public GameObject cena;
	private Rigidbody2D strump;

	// Use this for initialization
	void Start () {
		strump = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 0.0F && Time.timeSinceLevelLoad <= 0.1F) {
			weapon.velocity = new Vector2(0, -2);
		}
		if (Time.timeSinceLevelLoad >= 1.0F && Time.timeSinceLevelLoad <= 1.05F) {
			try {
				Destroy (weapon.gameObject);
			} catch (MissingReferenceException e) {

			}
		}
		if (Time.timeSinceLevelLoad >= 1.7F && Time.timeSinceLevelLoad <= 1.8F) {
			strump.rotation = 90;
		}
		if (Time.timeSinceLevelLoad >= 17.0F && Time.timeSinceLevelLoad <= 17.03F) {
			cena = (GameObject) Instantiate (cena, new Vector3 (3.069946F, -0.5922723F, -5), strump.gameObject.transform.rotation);
		}
		if (Time.timeSinceLevelLoad >= 26.0F && Time.timeSinceLevelLoad <= 26.2F) {
			cena.GetComponent<Rigidbody2D>().velocity = new Vector2(-6.0F, 0);
		}
		if (Time.timeSinceLevelLoad >= 27.7F) {
			Application.LoadLevel("win");
		}
	}
}
