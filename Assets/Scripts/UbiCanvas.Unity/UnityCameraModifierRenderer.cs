using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Color = UnityEngine.Color;

public class UnityCameraModifierRenderer : MonoBehaviour {
	public LineRenderer AABBRenderer;
	public CameraModifierComponent CameraModifier;
	public Pickable PickableForSelection;
	float prevZ = -99999;

	void InitRenderer() {
		var child = new GameObject("LocalAABB");
		child.transform.SetParent(transform, false);
		child.transform.localPosition = Vector3.zero;
		child.transform.localRotation = Quaternion.identity;
		child.transform.localScale = Vector3.one;
		AABBRenderer = child.AddComponent<LineRenderer>();
		AABBRenderer.material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
		AABBRenderer.useWorldSpace = false;
		AABBRenderer.widthMultiplier = 0.10f;
		AABBRenderer.sortingLayerName = "Gizmo-Line";
		Color color = Color.green;
		AABBRenderer.material.color = color;
		AABBRenderer.startColor = color;
		AABBRenderer.endColor = color;
		AABBRenderer.loop = true;
		AABBRenderer.positionCount = 4;
		AABBRenderer.SetPositions(new Vector3[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(1, 1, 0),
			new Vector3(1, -1, 0),
		});
	}

	void UpdateRenderer() {
		if (AABBRenderer == null) InitRenderer();

		SetPositions(AABBRenderer, CameraModifier.localAABB);
	}

	void SetPositions(LineRenderer line, AABB aabb) {
		if (aabb == null) aabb = new AABB();
		if (aabb.MIN == null) aabb.MIN = new Vec2d();
		if (aabb.MAX == null) aabb.MAX = new Vec2d();

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
			if (AABBRenderer != null) {
				float z = transform.position.z;
				if (z != prevZ) {
					prevZ = z;
					ZListManager zman = Controller.Obj.zListManager;
					zman.zDict[AABBRenderer] = z;
				}
			}
			if (isSelected) {
				UpdateSelectionDisplay();
			}
		}
		if (AABBRenderer != null) AABBRenderer.enabled = isSelected;
	}
}
