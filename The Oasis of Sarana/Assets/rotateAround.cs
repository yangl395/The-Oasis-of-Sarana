using UnityEngine;
using System.Collections;

public class rotateAround : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public GameObject Char;
	public GameObject Player;
	private float xscale;
	private int shaking = 0;
	private bool isShaking = false;
	private Vector3 vp;
	// Use this for initialization
	void Start () {
		vp=Camera.main.transform.localPosition;
		Player = GameObject.Find ("CapsulePlayer");
		Char = GameObject.Find ("char");
		xscale = Char.transform.localScale.x;
	}
	public void shakeMe(){
		isShaking=true;
	}
	// Update is called once per frame
	void Update () {
		if (!GameObject.Find ("Boss")) {
			shakeMe ();
			speed += 0.08f; 
		}
		if (Player.transform.position.y < -3f) {
			print ("die");
			Player.GetComponent<movePlayer> ().die ();
		}
		if (isShaking) {
			shaking++;
			Camera.main.transform.localPosition = vp + new Vector3 (Random.Range (-0.15f, 0.15f), Random.Range (-0.15f, 0.15f), Random.Range (-0.15f, 0.15f));
			if (shaking > 30) {
				shaking = 0;
				isShaking = false;
				Camera.main.transform.localPosition = vp;
			}
		}

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
