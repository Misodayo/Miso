using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PacemakerSelect : MonoBehaviour {

	public void OnClick() {

		SceneManager.LoadScene("PacemakerSelectScene");
	}
}
