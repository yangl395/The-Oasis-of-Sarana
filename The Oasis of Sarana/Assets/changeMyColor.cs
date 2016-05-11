using UnityEngine;
using System.Collections;

public class changeMyColor : MonoBehaviour {

	public bool inLight = true;
	public Rigidbody playerBody;
	public SpriteRenderer playerColor;
	public Color yellowish;
	public Color white;
	private float yellowSlide;
	private float y2;
	private wind myWind;
	// Use this for initialization
	void Start () {
		myWind=GameObject.Find("wind").GetComponent<wind> ();
		playerColor = GameObject.Find("char").GetComponent<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<ParticleSystem> ().forceOverLifetime.x= myWind.vx;


		//= new Vector3 (myWind.vx, myWind.vz, 0.06f);
		if (inLight == true) {

			yellowSlide = 6.8f * ( Mathf.Abs (playerBody.position.x - gameObject.transform.position.x));
			//print (yellowSlide);
			playerColor.color = new Color(1f, 1f, yellowSlide+0.4f, 1f);

			/*if (3.3 - Mathf.Abs (playerBody.position.x - gameObject.transform.position.x) > 2) {
				playerColor.color = yellowish;
			} else if (3.3 - Mathf.Abs (playerBody.position.x - gameObject.transform.position.x) < 2) {
				playerColor.color = white;
			}*/
	
	}
	}

	void OnTriggerEnter (Collider other) {
		
		if(other.CompareTag("Player")){
		inLight = true;
		playerBody = other.GetComponent<Rigidbody> ();
		}

		
	}

	void OnTriggerExit (Collider other) {

		if (other.CompareTag ("Player")) {
		//inLight = false;
		}

	}
}
