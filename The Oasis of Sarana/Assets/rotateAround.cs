using UnityEngine;
using System.Collections;

public class rotateAround : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public GameObject player;
	private bool jump;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//print (jump);

		if (Input.GetAxis ("Horizontal") > 0) {
			transform.Rotate (-Vector3.up * speed * Time.deltaTime);
		}

		if (Input.GetAxis ("Horizontal") < 0) {
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (jump = true) {
				jump = false;	
				player.GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);
			}
		}
	
	}

	void OnCollisionEnter (Collision other){
		jump = true;
	}



}
