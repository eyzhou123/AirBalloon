using UnityEngine;
using System.Collections;

public class coin_script : MonoBehaviour {

	public float scroll_speed;
	private Vector3 start_pos;

	public Sprite sprite;
	
	
	// Use this for initialization
	void Start () {
		start_pos = transform.position;
		scroll_speed = -0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		//		float new_position = Mathf.Repeat (Time.time * scroll_speed, tile_height);
		//		transform.position = start_pos + Vector3.forward * new_position;



		Vector3 new_position = transform.position += new Vector3 (0.0f, scroll_speed, 0.0f);
		transform.position = new_position;

		if (new_position.y < -5.0f) {
			Destroy(this.gameObject);
		}


		
	}



//	void OnCollisionEnter2D(Collision2D col){
//		if (col.gameObject.name == "Balloon")
//		{
//			Destroy(col.gameObject);
//		}
//	}
}
