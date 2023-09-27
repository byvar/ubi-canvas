using UnityEngine.UI;
using UnityEngine;

public class Tooltip : MonoBehaviour {
	public Text text;
	public Image background;
	public RectTransform canvas;
	private float alpha = 1f;

	public void Show(string text, float alpha) {
		var oldText = this.text.text;
		if (oldText != text) {
			this.text.text = text;
		}
		if(!gameObject.activeSelf) gameObject.SetActive(true);
		if (alpha != this.alpha) {
			this.alpha = alpha;
			background.color = new Color(background.color.r, background.color.g, background.color.b, background.color.a * alpha);
			this.text.color = new Color(this.text.color.r, this.text.color.g, this.text.color.b, this.text.color.a * alpha);
		}
	}

	public void Hide() {
		if (gameObject.activeSelf) gameObject.SetActive(false);
	}
	public void SetWorldPosition(Vector3 worldPos) {
		Vector2 localPoint;
		var screenPoint = RectTransformUtility.WorldToScreenPoint(Camera.main, worldPos);
		RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, screenPoint, null, out localPoint);
		transform.localPosition = localPoint;
	}


    void Update() {
		alpha = Mathf.Clamp01(alpha);
		/*if (alpha == 0f) {
			gameObject.SetActive(false);
		} else {
			gameObject.SetActive(true);
		}*/
    }
}
