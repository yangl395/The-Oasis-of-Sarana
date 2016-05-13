using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Transform target;
	public GameObject fireball;
	private float ay;
	private GameObject mainPlayer;
	private Boss mainBoss;
	private bool fire = false;

	// Use this for initialization
	void Start () {
		mainPlayer = GameObject.Find ("CapsulePlayer");
		mainBoss = GameObject.Find ("Boss").GetComponent<Boss>();
		ay = transform.localPosition.y;
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.eulerAngles = new Vector3 (-12, transform.eulerAngles.y+180, 0);

	}

	void OnTriggerStay(Collider c){
		if (c.gameObject.name == "CapsulePlayer") {
			FireBall ();
			transform.localPosition = new Vector3 (transform.localPosition.x, 0.08f, transform.localPosition.z);
		}
			
	}
	void OnTriggerExit(Collider c){
		if (c.gameObject.name == "CapsulePlayer") {
			print ("e");
			Invoke ("TurnOn", 3);
			transform.localPosition = new Vector3 (transform.localPosition.x, ay, transform.localPosition.z);
		}

	}
	public void FireBall (){
		if (fire == false) {
			Instantiate (fireball, transform.position, transform.rotation);
			fire = true;
		}
	}

	public void TurnOn(){
		fire = false;
	}
}
