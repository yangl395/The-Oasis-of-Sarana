using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	// Use this for initialization
	public int hp=10;
	private GameObject mySkull;
	float a=0;
	bool isHit=false;
	void Start () {
		mySkull = GameObject.Find ("Skull Head");
	}	
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0) {
		}
		if (isHit) {
			a += 0.5f;
			var col = mySkull.GetComponent<SpriteRenderer> ().color;
			col.a= (Mathf.Floor(a)%2 == 0) ? 0: 255;
			print (col.a);
			if (a >= 20f) {
				isHit = false;
				col.a = 255;
				a = 0f;
			}
			mySkull.GetComponent<SpriteRenderer> ().color = col;
		}
	}
	public void hit(){
		isHit = true;

	}
}
