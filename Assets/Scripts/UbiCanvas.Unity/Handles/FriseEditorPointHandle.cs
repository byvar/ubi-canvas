using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class FriseEditorPointHandle : UnityHandle {
	private LineRenderer lr;
	public PolyLineEdge Data { get; set; }

	public override float HandleScale => 0.3f + Data.Scale;

	public FriseEditorPointHandle target;

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	public override void ManualUpdate() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
			UpdateLine();
		}
	}

	void UpdateLine() {
		if (target != null) {
			lr.positionCount = 5;
			var lerp = Vector3.Lerp(transform.position, target.transform.position, 0.5f);
			var perp = Vector2.Perpendicular(target.transform.position - transform.position).normalized * 0.2f;
			lr.SetPositions(new Vector3[] {
				transform.position,
				lerp,
				new Vector3(lerp.x + perp.x, lerp.y + perp.y, lerp.z),
				lerp,
				target.transform.position
			});
		}
	}
	public override void CreateMesh() {
		base.CreateMesh();
		if (target != null) {
			lr = gameObject.AddComponent<LineRenderer>();
			lr.material = new Material(manager.lineMaterial);
			lr.useWorldSpace = true;
			lr.widthMultiplier = 0.15f;
			lr.sortingLayerName = "Gizmo-Line";
			Color color = Color.white;
			color = Data.HoleMode switch {
				PolyLineEdge.Hole.None => Color.white,
				PolyLineEdge.Hole.Visual => Color.yellow,
				PolyLineEdge.Hole.Collision => Color.blue,
				PolyLineEdge.Hole.Both => Color.black,
				_ => Color.white,
			};
			lr.material.color = color;
			lr.startColor = color;
			lr.endColor = color;
		}
	}
}
