using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	public bool jump = false;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame

	void OnCollisionEnter (Collision other){
		print (other.gameObject.tag);
		if (other.gameObject.tag == "Tower") {
			if (jump) {
				if (other.gameObject.name == "Shooter") {
					other.gameObject.GetComponent<Shooter> ().FireBall ();
				}
				jump = false;
			}
		}
	}
}
