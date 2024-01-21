using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Color = UnityEngine.Color;

public class UnityBoxInterpolatorRenderer : MonoBehaviour {
	public LineRenderer InnerRenderer;
	public LineRenderer OuterRenderer;
	public BoxInterpolatorComponent BoxInterpolator;
	public Pickable PickableForSelection;
	float prevZ = -99999;

	void InitRenderer() {
		var child = new GameObject("Inner Box");
		child.transform.SetParent(transform, false);
		child.transform.localPosition = Vector3.zero;
		child.transform.localRotation = Quaternion.identity;
		child.transform.localScale = Vector3.one;
		InnerRenderer = child.AddComponent<LineRenderer>();
		InnerRenderer.material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
		InnerRenderer.useWorldSpace = false;
		InnerRenderer.widthMultiplier = 0.10f;
		InnerRenderer.sortingLayerName = "Gizmo-Line";
		Color color = Color.cyan;
		InnerRenderer.material.color = color;
		InnerRenderer.startColor = color;
		InnerRenderer.endColor = color;
		InnerRenderer.loop = true;
		InnerRenderer.positionCount = 4;
		InnerRenderer.SetPositions(new Vector3[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(1, 1, 0),
			new Vector3(1, -1, 0),
		});

		child = new GameObject("Outer Box");
		child.transform.SetParent(transform, false);
		child.transform.localPosition = Vector3.zero;
		child.transform.localRotation = Quaternion.identity;
		child.transform.localScale = Vector3.one;
		OuterRenderer = child.AddComponent<LineRenderer>();
		OuterRenderer.material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
		OuterRenderer.useWorldSpace = false;
		OuterRenderer.widthMultiplier = 0.10f;
		OuterRenderer.sortingLayerName = "Gizmo-Line";
		color = Color.blue;
		OuterRenderer.material.color = color;
		OuterRenderer.startColor = color;
		OuterRenderer.endColor = color;
		OuterRenderer.loop = true;
		OuterRenderer.positionCount = 4;
		OuterRenderer.SetPositions(new Vector3[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(1, 1, 0),
			new Vector3(1, -1, 0),
		});
	}

	void UpdateRenderer() {
		if(OuterRenderer == null || InnerRenderer == null) InitRenderer();

		SetPositions(InnerRenderer, BoxInterpolator.innerBox);
		SetPositions(OuterRenderer, BoxInterpolator.outerBox);
	}

	void SetPositions(LineRenderer line, AABB aabb) {
		if(aabb == null) aabb = new AABB();
		if(aabb.MIN == null) aabb.MIN = new Vec2d();
		if(aabb.MAX == null) aabb.MAX = new Vec2d();

		line.SetPositions(new Vector3[]{
			new Vector3(aabb.MIN.x, aabb.MIN.y, 0),
			new Vector3(aabb.MIN.x, aabb.MAX.y, 0),
			new Vector3(aabb.MAX.x, aabb.MAX.y, 0),
			new Vector3(aabb.MAX.x, aabb.MIN.y, 0),
		});
	}

	void UpdateSelectionDisplay() {

	}

	private void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		bool isSelected = PickableForSelection != null && Controller.Obj.SelectedObject?.pickable == PickableForSelection;
		if (isSelected) {
			UpdateRenderer();
			if (OuterRenderer != null && InnerRenderer != null) {
				float z = transform.position.z;
				if (z != prevZ) {
					prevZ = z;
					ZListManager zman = Controller.Obj.zListManager;
					zman.zDict[OuterRenderer] = z;
					zman.zDict[InnerRenderer] = z;
				}
			}
			if (isSelected) {
				UpdateSelectionDisplay();
			}
		}
		if (InnerRenderer != null) InnerRenderer.enabled = isSelected;
		if (OuterRenderer != null) OuterRenderer.enabled = isSelected;
	}
}
