using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToTop : MonoBehaviour {

	public void OnClick() {
		SceneManager.LoadScene("StartScene");
	}
}
