using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Transform target;
	public GameObject fireball;

	private GameObject mainPlayer;

	// Use this for initialization
	void Start () {
		mainPlayer = GameObject.Find ("CapsulePlayer");
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.eulerAngles += new Vector3 (0, 180, 0);

	}

	public void FireBall (){
		Instantiate (fireball, transform.position, transform.rotation);
	}
}
