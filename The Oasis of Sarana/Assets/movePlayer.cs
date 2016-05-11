using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	public bool jump = false;
	public int hp = 100;
	// Use this for initialization
	void Start () {


	}
	public void die(){
		print ("die");
	}
	// Update is called once per frame

	void OnCollisionEnter (Collision other){
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
