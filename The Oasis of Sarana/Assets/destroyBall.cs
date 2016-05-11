using UnityEngine;
using System.Collections;

public class destroyBall : MonoBehaviour {

	// Use this for initialization
	private int destroyTime=0;	

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		destroyTime++;
		if (destroyTime == 50) {
			Destroy (gameObject);
		}
	}

}

