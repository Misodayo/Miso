using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {

	public void OnClick() {

		SceneManager.LoadScene("ResultScene");
	}
}
