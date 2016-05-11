using UnityEngine;
using System.Collections;

public class lookAtMe : MonoBehaviour {

	public Transform target;
	public GameObject fireball;
	private int fireTime=0;
	public GameObject Boss;
	private float Rd;
	// Use this for initialization
	void Start () {
		Boss = GameObject.Find ("Boss");
	}
	
	// Update is called once per frame
	void Update () {
		if (Boss.GetComponent<Boss> ().hp > 10) {
			transform.LookAt (target);
			if (fireTime == 0) {
				Rd = Random.Range (0, 1f);
			}
			fireTime++;
			if (fireTime >= 60) {
				if (Rd < 0.6f) {
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
	}

	void FireBall (){
		GameObject.Find ("sk").GetComponent<Animator> ().SetTrigger ("Fire");
		Instantiate (fireball, transform.position, transform.rotation);
	}
}
