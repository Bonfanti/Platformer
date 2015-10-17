using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	public Transform platform;
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
	
	}
}
