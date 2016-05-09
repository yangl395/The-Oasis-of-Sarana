using UnityEngine;
using System.Collections;

public class wind : MonoBehaviour {

	// Use this for initialization
	float vx,vz,rot;
	int timer=0;
	void Start () {
		rot = 0;
	}
	
	// Update is called once per frame
	void Update () {
		vx = -Mathf.Sin (rot / 180 * Mathf.PI) * 3;
		vz = Mathf.Cos (rot / 180 * Mathf.PI) * 3;
		rot += Random.Range (0, 0.2f);
		if (rot > 360){
			rot = 0;
		}
		transform.eulerAngles = new Vector3(19,-rot-180,180);
		transform.position = new Vector3 (vx, transform.position.y, vz);

	}
}
