using UnityEngine;
using System.Collections;

public class MoveFireballBoss : MonoBehaviour {

	// Use this for initialization
	movePlayer myPlayer;
	void Start () {
		myPlayer = GameObject.Find ("CapsulePlayer").GetComponent<movePlayer> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (transform.forward * 0.02f);
	}
	void OnTriggerEnter(Collider c){
		if (c.gameObject.name == "CapsulePlayer") {
			print (myPlayer.hp);
			myPlayer.hp--;
			print (myPlayer.hp);
			myPlayer.hit ();
		}
	}
}
