using UnityEngine;
using System.Collections;

public class ButtonScript_CameraChange : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeCamera()
    {
        if (PlayerController.TopView)
        {
            PlayerController.TopView = false;
        }
        else
        {
            PlayerController.TopView = true;
        }
    }       
}