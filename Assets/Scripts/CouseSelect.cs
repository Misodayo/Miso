using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CouseSelect : MonoBehaviour {

	public void OnClick() {
		Debug.Log ("test");
		SceneManager.LoadScene("CourseSelectScene");
	}
}
