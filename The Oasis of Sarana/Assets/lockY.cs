using UnityEngine;
using System.Collections;

public class lockY : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Q)) {
			Time.timeScale = 0.1f;
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			Time.timeScale = 1;
		}

		transform.position = new Vector3 (transform.position.x, 2.611089f, transform.position.z);
	
	}
}
