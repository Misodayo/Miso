using UnityEngine;
using System.Collections;

public class CouseSelectController : MonoBehaviour {

	public GameObject[] images;

	public static int selectNum;

	public float distance = 100f;

	// Use this for initialization
	void Start () {

		images = GameObject.FindGameObjectsWithTag ("couseImage");

		Debug.Log (images.Length);
	
	}
	
	// Update is called once per frame
	void Update () {
		// 左クリックを取得
		/*if (Input.GetMouseButtonDown(0)) {

			// Debug.Log ("クリック");

			// クリックしたスクリーン座標をrayに変換
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// Rayの当たったオブジェクトの情報を格納する
			RaycastHit hit = new RaycastHit();
			// オブジェクトにrayが当たった時
			if (Physics.Raycast(ray, out hit, distance)) {
				// rayが当たったオブジェクトの名前を取得
				string objectName = hit.collider.gameObject.name;
				Debug.Log(objectName);
			}
		}*/
	}

	void selectCouseImage() {

	}
}
