using UnityEngine;
using System.Collections;

public class CouseBoardController : MonoBehaviour {

	// mouseOverで選択と判定する時間
	public float judgeTime;

	// Objectに最初にmouseOverした時間
	// mouseが離れるとリセットされる
	private float firstMouseOverTime;

	private bool isFirstFlg;

	void Start()
	{
		firstMouseOverTime = 0;
		isFirstFlg = true;
	}

	void OnMouseOver()
	{
		if (isFirstFlg) {
			firstMouseOverTime = Time.time;
			isFirstFlg = false;
		} else {
			float onMouseTime = Time.time - firstMouseOverTime;
			print (onMouseTime);

			if(judgeTime <= onMouseTime) {
				print ("選択されました");
			}
		}

		//this.GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, 1f, 0.1f);
		this.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.67f, 0.92f, 1f, 1f));
	}

	void OnMouseExit()
	{
		print ("exit");
		this.GetComponent<Renderer>().material.color = Color.white;
		isFirstFlg = true;
	}
}
