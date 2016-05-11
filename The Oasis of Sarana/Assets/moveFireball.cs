using UnityEngine;
using System.Collections;

public class moveFireball : MonoBehaviour {

	// Use this for initialization
	Boss myBoss;
	void Start () {
		myBoss = GameObject.Find ("Boss").GetComponent<Boss> ();
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += (transform.forward * 0.02f);
	
	}
	void OnTriggerEnter(Collider c){
		
		if (c.gameObject.name == "Boss") {
			myBoss.hp--;
			GameObject.Find ("Rotation").GetComponent<rotateAround> ().shakeMe ();
			Destroy (gameObject);

		}
	}
}
