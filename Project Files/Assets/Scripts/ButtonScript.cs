using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	public void ResetLevel () {

		Application.LoadLevel (Application.loadedLevel);

	}
}