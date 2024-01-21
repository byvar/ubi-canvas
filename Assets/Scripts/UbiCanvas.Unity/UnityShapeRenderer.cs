using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Color = UnityEngine.Color;
using System.Linq;

public class UnityShapeRenderer : MonoBehaviour {
	public LineRenderer Renderer;
	public ShapeComponent ShapeComponent;
	public ShapeComponent_Template ShapeComponentTPL;
	public Pickable PickableForSelection;
	float prevZ = -99999;

	void InitRenderer() {
		var child = new GameObject("Inner Box");
		child.transform.SetParent(transform, false);
		child.transform.localPosition = Vector3.zero;
		child.transform.localRotation = Quaternion.identity;
		child.transform.localScale = Vector3.one;
		Renderer = child.AddComponent<LineRenderer>();
		Renderer.material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
		Renderer.useWorldSpace = false;
		Renderer.widthMultiplier = 0.075f;
		Renderer.sortingLayerName = "Gizmo-Line";
		Color color = Color.red;
		Renderer.material.color = color;
		Renderer.startColor = color;
		Renderer.endColor = color;
		Renderer.loop = true;
		Renderer.positionCount = 4;
		Renderer.SetPositions(new Vector3[]{
			new Vector3(-1, -1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(1, 1, 0),
			new Vector3(1, -1, 0),
		});
	}

	void UpdateRenderer() {
		if(Renderer == null) InitRenderer();

		SetPositions(Renderer, ShapeComponentTPL?.shape?.obj);
	}

	void SetPositions(LineRenderer line, PhysShape shape) {
		if (shape == null) {
			Renderer.positionCount = 0;
		} else {
			Vector3 baseOffset = new Vector3(ShapeComponentTPL?.offset?.x ?? 0f, ShapeComponentTPL?.offset?.y ?? 0f);
			baseOffset += new Vector3(ShapeComponent?.localOffset?.x ?? 0f, ShapeComponent?.localOffset?.y ?? 0f);
			Vector3 scale = new Vector3(ShapeComponent.localScale.x, ShapeComponent.localScale.y, 1f);

			Vector3[] points;
			void ChangeForUseShapeTransform() {
				// Inverse transform points
				/*if (!ShapeComponent.useShapeTransform) {
					var rot = Quaternion.Inverse(transform.rotation);
					points = points.Select(p => rot * p).ToArray();
					var scl = transform.lossyScale;
					if (scl.x != 0 && scl.y != 0) {
						scl = new Vector3(1f / scl.x, 1f / scl.y, 1f);
						points = points.Select(p => Vector3.Scale(p, scl)).ToArray();
					}
				}*/
			}
			
			switch (shape) {
				case PhysShapePolygon poly:
					Renderer.positionCount = poly.Points.Count;
					points = poly.Points.Select(p => Vector3.Scale(new Vector3(p.x, p.y, 0) + baseOffset, scale)).ToArray();
					ChangeForUseShapeTransform();
					Renderer.SetPositions(points);
					break;
				case PhysShapeCircle circle:
					var pointsCount = 16;
					var radius = circle.Radius;
					Renderer.positionCount = pointsCount;
					points = new Vector3[pointsCount];

					for (int i = 0; i < pointsCount; i++) {
						var rad = Mathf.Deg2Rad * (i * 360f / pointsCount);
						points[i] = new Vector3(Mathf.Cos(rad) * radius, Mathf.Sin(rad) * radius, 0);
						points[i] = Vector3.Scale(points[i] + baseOffset, scale);
					}
					ChangeForUseShapeTransform();
					Renderer.SetPositions(points);

					break;
				default:
					Renderer.positionCount = 0;
					break;
			}
		}
	}

	void UpdateSelectionDisplay() {

	}

	private void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		bool isSelected = PickableForSelection != null && Controller.Obj.SelectedObject?.pickable == PickableForSelection;
		if (isSelected) {
			UpdateRenderer();
			if (Renderer != null) {
				float z = transform.position.z;
				if (z != prevZ) {
					prevZ = z;
					ZListManager zman = Controller.Obj.zListManager;
					zman.zDict[Renderer] = z;
				}
			}
			if (isSelected) {
				UpdateSelectionDisplay();
			}
		}
		if (Renderer != null) Renderer.enabled = isSelected;
	}
}
