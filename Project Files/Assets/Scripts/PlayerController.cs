using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	public GameObject exit;
	public float speed;
    public int pickups;
    public static int pickupsref;
    public static bool TopView;

	void Start ()
	{
		ScoreManager.Score = 0;
        TopView = false;
	}
	void Awake ()
	{

	}
	void Update ()
	{
		//Code Here Called right before a frame...
		//Most Code Goes Here!
		/*
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Application.LoadLevel (Application.loadedLevel);
		}
		*/

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (TopView)
            {
                TopView = false;
            }
            else
            {
                TopView = true;
            }
        }

        pickupsref = pickups;

		if(ScoreManager.Score == pickups)
		{
		    exit.gameObject.SetActive (true);
        } 
        else 
        {
            exit.gameObject.SetActive (false);
		}
		

	}

	void FixedUpdate ()
	{
		//Code here called right before a Physics Calculation...
		//Put all PHYSICS code here
        /*
         * 
         * 
        */
        //float moveHorizontal = Input.acceleration.x;
        //float moveVertical = Input.acceleration.y;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rigidbody.AddForce (movement * speed * Time.deltaTime );
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive (false);
			ScoreManager.Score += 1;

		}

		if (other.gameObject.tag == "DeathTrap") 
		{
			Application.LoadLevel(Application.loadedLevel);
		}

		if (other.gameObject.tag == "Exit") 
		{
			if(Application.loadedLevel == 1)
			{
				Application.LoadLevel (2);
			}
            if (Application.loadedLevel == 2)
            {
                Application.LoadLevel(3);
            }
            if (Application.loadedLevel == 3)
            {
                Application.LoadLevel(4);
            }
            if (Application.loadedLevel == 4)
            {
                Application.LoadLevel(0);
            }
		}
	}

}
