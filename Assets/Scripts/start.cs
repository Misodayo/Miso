using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {
	public void OnClick() {
		// Debug.Log("Start Button click!");
		// 非表示にする
		//gameObject.SetActive(false);

		SceneManager.LoadScene ("ModeSelectScene");
		// Application.LoadLevel("ModeSelectScene");
	}
}
