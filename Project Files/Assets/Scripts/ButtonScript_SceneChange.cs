using UnityEngine;
using System.Collections;

public class ButtonScript_SceneChange : MonoBehaviour {

	public void SceneToChangeTo (int SceneNumber) {

		Application.LoadLevel (SceneNumber);

	}
}
