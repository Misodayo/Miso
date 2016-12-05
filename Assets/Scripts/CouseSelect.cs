using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class CouseSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler {

	// mouse overの判定用フラグ
	public bool isOver = false;

	public Image image { get { return GetComponent<Image>(); } }


	public void OnPointerEnter(PointerEventData eventData) {
		Debug.Log("Mouse enter");
		isOver = true;
		image.color = Color.red;
	}

	public void OnPointerExit(PointerEventData eventData) {
		Debug.Log("Mouse exit");
		isOver = false;
		image.color = Color.white;
	}

	public void OnPointerDown(PointerEventData eventData) {
		Debug.Log("Mouse down");
		Debug.Log(this.name);



		image.color = Color.yellow;

	}
}
