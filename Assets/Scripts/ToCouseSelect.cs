using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToCouseSelect : MonoBehaviour {

	public void OnClick() {
		Debug.Log ("test");
		SceneManager.LoadScene("CourseSelectScene");
	}
}
