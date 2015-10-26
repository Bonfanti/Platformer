using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public Trigger[] keys;
	
	private bool unlocked = false;
	private bool otherKeys, playerOnTrigger = false, opened = false;
	//private int timesCastleLoaded = 0;
	// Use this for initialization
	void Start () {
		if (keys.Length == 0) {
			otherKeys = false;
			unlocked = true;
		}
		else
			otherKeys = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (otherKeys && !unlocked) {
			bool unlock = false;
			for(int x = 0; x < keys.Length; x++)
			{
				if(keys[x].opened) unlock = true;
				else {
					unlock = false;
					break;
				}
			}
			if(unlock) unlocked = true;
		}

		if (playerOnTrigger && !opened && unlocked) {
			if(Input.GetKeyDown ("up")) {
				opened = true;
				print (Application.loadedLevel);
				Application.LoadLevel(Application.loadedLevel + 4);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		playerOnTrigger = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		playerOnTrigger = false;
	}
}
