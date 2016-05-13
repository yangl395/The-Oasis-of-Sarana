using UnityEngine;
using System.Collections;

public class camerashake : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public GameObject Char;
	public GameObject Player;
	private float xscale;
	private int shaking = 0;
	private bool isShaking = false;
	public Vector3 vp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Camera.main.transform.localPosition = vp + new Vector3 (Random.Range (-0.15f, 0.15f), Random.Range (-0.15f, 0.15f), Random.Range (-0.15f, 0.15f));
		if (shaking > 30) {
			shaking = 0;
			isShaking = false;
			Camera.main.transform.localPosition = vp;
	
	}
}
}
