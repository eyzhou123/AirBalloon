using UnityEngine;
using System.Collections;

public class bird_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 new_position = transform.position += new Vector3 (-0.05f, 0.0f, 0.0f);
		transform.position = new_position;

		if (new_position.x < -9.0f) {
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		// Got a coin
		Debug.Log ("hit balloon");
		if (col.gameObject.name == "Balloon") {
			Debug.Log ("hit balloon");
		}
	}
}
