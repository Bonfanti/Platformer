using UnityEngine;
using System.Collections;

public class TriggerBattle : MonoBehaviour {

	private bool isInTrigger = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isInTrigger && Input.GetKeyDown ("up")) {
			if(Application.loadedLevel != 8) Application.LoadLevel (Application.loadedLevel - 3);
			else Application.LoadLevel ("win");
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		isInTrigger = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		isInTrigger = false;
	}
}
