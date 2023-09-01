using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.UI;

public class FriseEditorPointBehaviour : MonoBehaviour {
	public Controller controller;
	public FriseEditorBehaviour editor;
	private SpriteRenderer sr;
	private SphereCollider sc;
	private LineRenderer lr;
	public PolyLineEdge Data { get; set; }
	public FriseEditorPointBehaviour target;

	// Use this for initialization
	void Start() {
	}

	public void Init() {
		CreateMesh();
		Deselect();
	}
	// Update is called once per frame
	void Update() {
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
	void CreateMesh() {
		var scale = 0.3f + Data.Scale;
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.sortingLayerName = "Gizmo";
		sr.size = Vector2.one * scale;
		sr.drawMode = SpriteDrawMode.Sliced;
		sc = gameObject.AddComponent<SphereCollider>();
		sc.radius = 0.2f * scale;
		if (target != null) {
			lr = gameObject.AddComponent<LineRenderer>();
			lr.material = new Material(editor.lineMaterial);
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

	public void Deselect() {
		var spr = controller.GetIcon("frieze_point", false);
		if (spr != null) {
			sr.sprite = spr;
		}
	}
	public void Select() {
		var spr = controller.GetIcon("frieze_point", true);
		if (spr != null) {
			sr.sprite = spr;
		}
	}
}
