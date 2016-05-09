using UnityEngine;
using System.Collections;

public class rotateAround : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public GameObject Char;
	public GameObject Player;
	private float xscale;

	// Use this for initialization
	void Start () {

		Player = GameObject.Find ("CapsulePlayer");
		Char = GameObject.Find ("char");
		xscale = Char.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {

		//print (jump);

		if (Input.GetAxis ("Horizontal") > 0) {
			Char.GetComponent<Animator> ().Play ("WalkAnimation");
			Char.transform.localScale = new Vector3 (xscale, Char.transform.localScale.y, Char.transform.localScale.z);
			transform.Rotate (-Vector3.up * speed * Time.deltaTime);
		} else if (Input.GetAxis ("Horizontal") < 0) {
			Char.GetComponent<Animator> ().Play ("WalkAnimation");
			Char.transform.localScale = new Vector3 (-xscale, Char.transform.localScale.y, Char.transform.localScale.z);
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		} else {
			Char.GetComponent<Animator> ().Play ("Idle Animation");
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			if (!Player.GetComponent<movePlayer>().jump ) {
				Player.GetComponent<movePlayer>().jump = true;	
				Player.GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpSpeed);
			}
		}
	}





}
