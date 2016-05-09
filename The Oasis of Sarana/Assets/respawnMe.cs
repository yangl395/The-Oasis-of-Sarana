using UnityEngine;
using System.Collections;

public class respawnMe : MonoBehaviour {

	// Use this for initialization
	Vector3 pos;
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 1.0f) {
			transform.position = pos;
			GetComponent<Rigidbody>().isKinematic = true; 
			GetComponent<Rigidbody>().isKinematic = false; 
		}
	}
}
