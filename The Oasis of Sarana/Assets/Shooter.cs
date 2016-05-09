using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public Transform target;
	public GameObject fireball;

	private GameObject mainPlayer;
	private Boss mainBoss;
	// Use this for initialization
	void Start () {
		mainPlayer = GameObject.Find ("CapsulePlayer");
		mainBoss = GameObject.Find ("Boss").GetComponent<Boss>();
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.eulerAngles = new Vector3 (-12, transform.eulerAngles.y+180, 0);

	}

	public void FireBall (){
		Instantiate (fireball, transform.position, transform.rotation);
	}
}
