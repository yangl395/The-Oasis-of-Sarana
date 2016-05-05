using UnityEngine;
using System.Collections;

public class lookAtMe : MonoBehaviour {

	public Transform target;
	public GameObject fireball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (target);

		if (Input.GetKeyDown (KeyCode.Q)) {
			FireBall ();
		}
	
	}

	void FireBall (){
		Instantiate (fireball, transform.position, transform.rotation);
	}
}
