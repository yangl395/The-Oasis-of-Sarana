using UnityEngine;
using System.Collections;

public class wind : MonoBehaviour {

	// Use this for initialization

	public float rot,vx,vz;
	int timer=300;
	void Start () {
		rot = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer--;
		GetComponent<ParticleSystem> ().startSpeed = timer/300f*8.1f;
		if (timer == -40) {
			timer = 300;
			float r = Random.Range (0, 1f);
			if (r < .25f) {
				rot = 0;
			} else if (r < .5f) {
				rot = 90;
			} else if (r < .75f) {
				rot = 180;
			} else {
				rot = 270;
			}

			vx = -Mathf.Sin (rot / 180 * Mathf.PI) * 3;
			vz = Mathf.Cos (rot / 180 * Mathf.PI) * 3;

			transform.eulerAngles = new Vector3(19,-rot-180,180);
			transform.position = new Vector3 (vx, transform.position.y, vz);

			GetComponent<ParticleSystem> ().startSpeed = 4.1f;
			GetComponent<AudioSource> ().Play (0);
		}
		GetComponent<AudioSource> ().volume = GetComponent<ParticleSystem> ().startSpeed / 8.1f;
	}
}
