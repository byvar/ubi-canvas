using UbiCanvas.Helpers;
using UnityEngine;

public class PickableOutlineDisplay : MonoBehaviour {
	public Controller controller;

	public UnityPickable pickable;
	private LineRenderer lr;
	private Tooltip tooltip;

	public RectTransform UICanvas;
	public Tooltip TooltipPrefab;

	public float alpha = 1f;

    private void UpdateHighlight() {
		if (lr == null) {
			lr = gameObject.AddComponent<LineRenderer>();
			lr.material = new Material(FindObjectOfType<FriseEditorBehaviour>().lineMaterial);
			lr.useWorldSpace = true;
			lr.widthMultiplier = 0.03f;
			lr.sortingLayerName = "Gizmo-Line";
			Color color = new Color(1f,1f,1f, alpha);
			lr.material.color = color;
			lr.startColor = color;
			lr.endColor = color;
			lr.positionCount = 0;
		}
		if (tooltip == null) {
			tooltip = GameObject.Instantiate(TooltipPrefab);
			tooltip.transform.SetParent(UICanvas);
			tooltip.transform.localPosition = Vector3.zero;
			tooltip.canvas = UICanvas;
			tooltip.Hide();
		}
		if (pickable != null) {
			lr.enabled = true;
			lr.positionCount = 4;
			lr.loop = true;
			lr.SetPositions(new Vector3[] {
				pickable.transform.TransformPoint(new Vector3(-0.5f, -0.5f)),
				pickable.transform.TransformPoint(new Vector3(0.5f, -0.5f)),
				pickable.transform.TransformPoint(new Vector3(0.5f, 0.5f)),
				pickable.transform.TransformPoint(new Vector3(-0.5f, 0.5f))
			});
			tooltip.Show(pickable.pickable.USERFRIENDLY, alpha);
			tooltip.SetWorldPosition(pickable.transform.position);
		} else {
			lr.enabled = false;
			lr.positionCount = 0;
			tooltip.Hide();
		}
    }
    void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
			UpdateHighlight();
		}
    }
}
