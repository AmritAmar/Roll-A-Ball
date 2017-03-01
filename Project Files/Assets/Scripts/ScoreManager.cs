using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public static int Score;
	Text text1;

	// Use this for initialization
	void Awake () {

		text1 = GetComponent <Text> ();
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = "Cubes Left: " + (PlayerController.pickupsref - Score);
	}
}
