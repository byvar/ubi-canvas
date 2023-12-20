using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.UI;

public abstract class UnityHandle : MonoBehaviour {
	public UnityHandleManager manager;
	protected SpriteRenderer sr;
	protected SphereCollider sc;
	public abstract float HandleScale { get; }

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
			//UpdateLine();
		}
	}

	public virtual void CreateMesh() {
		var scale = HandleScale;
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.sortingLayerName = "Gizmo";
		sr.size = Vector2.one * scale;
		sr.drawMode = SpriteDrawMode.Sliced;
		sc = gameObject.AddComponent<SphereCollider>();
		sc.radius = 0.2f * scale;
	}

	public void Deselect() {
		var spr = Controller.Obj.GetIcon("frieze_point", false);
		if (spr != null) {
			sr.sprite = spr;
		}
	}
	public void Select() {
		var spr = Controller.Obj.GetIcon("frieze_point", true);
		if (spr != null) {
			sr.sprite = spr;
		}
	}
}
