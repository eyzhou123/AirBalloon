using UnityEngine;
using System.Collections;

public class play_button_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		// if we clicked the play button
		if (this.name == "PlayButton" || this.name == "PlayAgain")
		{
			// load the game
			Application.LoadLevel("AirBalloon_s1");
		}
	}
}
