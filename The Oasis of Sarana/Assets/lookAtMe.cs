using UnityEngine;
using System.Collections;

public class lookAtMe : MonoBehaviour {

	public Transform target;
	public GameObject fireball;
	private int fireTime=0;
	private float Rd;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (target);
		if (fireTime == 0) {
			Rd = Random.Range (0, 1f);
		}
		fireTime++;
		if (fireTime >= 60) {
			if (Rd < 0.2f) {
				if (fireTime % 10 == 0) {
					FireBall ();
				}
				if (fireTime == 100) {
					fireTime = 0;
				}
			} else {
				FireBall ();
				fireTime = 0;
			}
		}
	
	}

	void FireBall (){
		Instantiate (fireball, transform.position, transform.rotation);
	}
}
