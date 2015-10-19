using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	public Transform platform;
	public Transform c;
	public Transform backdrop;
	private float prevValue;
	private bool left;
	// Use this for initialization
	void Start () {
		if(platform.position.x == -1.88F){
			for (int x = 0; x < 3; x++) {
				Vector3 v = new Vector3 (x*10+5, Random.Range (-3, 2), 0);
				Instantiate (platform, v, this.transform.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("left")) left = true;
		if (Input.GetKeyUp ("left"))
			left = false;
		if (Mathf.Abs (prevValue - (c.position.x % 5.14F)) > 5 ) {
			int sign = 4;
			if(left) sign = -4;
			Vector3 pos2 = new Vector3((float)(c.position.x + sign + 5.14F), 1.5F, 10.0F);
			Instantiate(backdrop, pos2, this.transform.rotation);
		}
		else prevValue = c.position.x % 5.14F;
	}
}
