using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	// Use this for initialization
	public float hp=10;
	private GameObject mySkull,mySk,myHand1,myHand2;
	float a=0;
	bool isHit=false;
	void Start () {
		mySkull = GameObject.Find ("Skull Head");
		mySk=GameObject.Find ("sk");
		myHand1=GameObject.Find ("hand1");
		myHand2=GameObject.Find ("hand2");


	}	
	
	// Update is called once per frame
	void Update () {
		if (hp <= 10) {
			hp -= 0.1f;
			transform.Translate (Vector3.down * 0.05f);
		}
		if (hp <= 0) {
			Destroy (gameObject);
			GameObject p = GameObject.Find ("Rotation");

			for(int i=0; i<GameObject.Find ("Debris").gameObject.transform.childCount; i++)
			{
				GameObject.Find ("Debris").gameObject.transform.GetChild(i).gameObject.active = true;
			}

			p.transform.position = new Vector3 (0, 1.7f, 0);
			p.transform.eulerAngles = new Vector3 (0, 147.0183f, 0);


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
			mySk.GetComponent<SpriteRenderer> ().color = col;
			myHand1.GetComponent<SpriteRenderer> ().color = col;
			myHand2.GetComponent<SpriteRenderer> ().color = col;
		}
	}
	public void hit(){
		isHit = true;
		GetComponent<AudioSource> ().Play (0);
	}
}
