using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	private Vector3 hSpeed;
	private Vector3 vSpeed;
	private Vector3 zeroSpeed;
	public float velocity;
	private float xscale;
	private bool hit = false;

	// Use this for initialization
	void Start () {

		xscale = transform.localScale.x;
	
		hSpeed = new Vector3 (velocity, 0, 0);
		vSpeed = new Vector3 (0, velocity, 0);
		zeroSpeed = new Vector3 (0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {
		if (!hit) {
			if (Input.GetAxis ("Horizontal") > 0) {
				GetComponent<Animator> ().Play ("WalkAnimation");
				transform.localScale = new Vector3 (xscale, transform.localScale.y, transform.localScale.z);
				transform.Translate (Vector3.right * velocity * Time.deltaTime);
			} else if (Input.GetAxis ("Horizontal") < 0) {
				GetComponent<Animator> ().Play ("WalkAnimation");
				transform.localScale = new Vector3 (-xscale, transform.localScale.y, transform.localScale.z);
				transform.Translate (-Vector3.right * velocity * Time.deltaTime);
			} else {
				GetComponent<Animator> ().Play ("Idle Animation");
			}

		}
		if (Input.GetAxis ("Vertical") > 0) {
			transform.Translate (Vector3.up * velocity * Time.deltaTime);
		} else if (Input.GetAxis ("Vertical") < 0) {
			transform.Translate (-Vector3.up * velocity * Time.deltaTime);
		}
	
	}
	void OnTriggerStay(Collider c){
		print (c.gameObject.name);
		if (c.gameObject.name == "Tower") {
			hit = true;
		}
	}
	void OnTriggerExit(Collider c){
		if (c.gameObject.name == "Tower") {
			hit = false;
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.CompareTag ("Wall")) {
			print ("hey");
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
		}
	}
}
