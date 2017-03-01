using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject PlayerObject;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
	
		offset = transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {
	
		if (PlayerController.TopView) {
			transform.position = (new Vector3(PlayerObject.transform.position.x, PlayerObject.transform.position.y + 7, PlayerObject.transform.position.z));
			transform.eulerAngles = (new Vector3(90f, 0f, 0f));
        }
        else
        {
            transform.position = PlayerObject.transform.position + offset;
            transform.eulerAngles = new Vector3(45f, 0f, 0f);
        }

	}
}
