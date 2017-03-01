using UnityEngine;
using System.Collections;

public class SpotlightScript : MonoBehaviour {

	public GameObject PlayerObject;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
	
		offset = transform.position; 

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = PlayerObject.transform.position + offset;

	}
}
