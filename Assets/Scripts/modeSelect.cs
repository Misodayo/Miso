using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class modeSelect : MonoBehaviour {

	public void OnClick() {

		switch (transform.name) {
		case "AdviceBtn":
			SceneManager.LoadScene("AdviceScene");
			break;
		case "TraningBtn":
			SceneManager.LoadScene("TrainingScene");
			break;
		default:
			break;
		}
	}
}
