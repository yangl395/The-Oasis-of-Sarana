using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	public bool jump = false;
	public int hp = 100;
	bool isHit=false;
	float a=0;
	GameObject myChar;
	// Use this for initialization
	void Start () {
		myChar = GameObject.Find ("char");

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
	void Update(){
		if (isHit) {
			a += 0.5f;
			var col = myChar.GetComponent<SpriteRenderer> ().color;
			col.a= (Mathf.Floor(a)%2 == 0) ? 0: 255;
			print (col.a);
			if (a >= 10f) {
				isHit = false;
				col.a = 255;
				a = 0f;
			}
			myChar.GetComponent<SpriteRenderer> ().color = col;
		}
	}
	public void hit(){
		GetComponent<AudioSource> ().Play ();
		isHit = true;

	}
}
