using UnityEngine;
using System.Collections;

public class DestroyMe : MonoBehaviour {

	public float destroyTime=0;	

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (destroyTime > 0) {
			destroyTime++;
		}
		if (destroyTime == 30) {
			GetComponent<MeshCollider> ().enabled = false;
			Rigidbody newRigidBodyComponent = gameObject.AddComponent<Rigidbody>();
			GetComponent<Rigidbody> ().useGravity = true;
		}
	}
	void OnCollisionEnter(Collision c){
		
		if (c.gameObject.name == "CapsulePlayer") {
			if (c.gameObject.GetComponent<Rigidbody> ().velocity.y < -0.8f) {
				//GameObject.Find ("CapsulePlayer").GetComponent<movePlayer> ().die ();
			}
			//print (c.gameObject.name);
			destroyTime=1;
		}
	}
			
}
