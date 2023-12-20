using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class UnityBezierPointHandle : UnityHandle {
	private LineRenderer lr;
	public RO2_BezierNode Node;

	public override float HandleScale => 0.3f + Node.scale;

	public Transform RelativeTransform;
	public UnityBezierPointHandle MainPoint;

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
			UpdateLine();
			UpdateData();
		}
	}

	void UpdateLine() {
		if (MainPoint != null) {
			lr.positionCount = 2;
			lr.SetPositions(new Vector3[] {
				transform.position,
				MainPoint.transform.position
			});
		}
	}
	void UpdateData() {
		var relativePoint = RelativeTransform.InverseTransformPoint(transform.position);
		if (MainPoint != null) {
			// This is a tangent line
			var localTangent = relativePoint;
			Node.tangent = new UbiArt.Vec2d(localTangent.x, localTangent.y);
		} else {
			Node.pos = new UbiArt.Vec3d(relativePoint.x, relativePoint.y, -relativePoint.z);
		}
	}
	public override void CreateMesh() {
		base.CreateMesh();
		if (MainPoint != null) {
			lr = gameObject.AddComponent<LineRenderer>();
			lr.material = new Material(manager.lineMaterial);
			lr.useWorldSpace = true;
			lr.widthMultiplier = 0.05f;
			lr.sortingLayerName = "Gizmo-Line";
			Color color = Color.green;
			lr.material.color = color;
			lr.startColor = color;
			lr.endColor = color;
		}
	}
}
