using UnityEngine;
using System.Collections;

public class DestroyMe : MonoBehaviour {

	public float destroyTime=0;	

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (destroyTime == 35) {
			GetComponent<MeshCollider> ().enabled = false;
			Rigidbody newRigidBodyComponent = gameObject.AddComponent<Rigidbody>();
			GetComponent<Rigidbody> ().useGravity = true;
		}
	}
	void OnCollisionStay(Collision c){
		print (c.gameObject.name);
		if (c.gameObject.name == "CapsulePlayer") {
			//print (c.gameObject.name);
			destroyTime++;
		}
	}
			
}
