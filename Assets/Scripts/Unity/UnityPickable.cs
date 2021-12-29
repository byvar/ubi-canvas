using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using System.Linq;

public class UnityPickable : MonoBehaviour {
	public Pickable pickable;
	private SpriteRenderer sr;
	private bool inited = false;

	private void Init() {
		inited = true;
		CreateMesh();
		UpdateGizmo();
	}

	private void Update() {
		if (Controller.LoadState != Controller.State.Finished) return;
		if (!inited) Init();
		if (sr != null) {
			sr.enabled = MapLoader.Loader.controller.displayGizmos;
			if (sr.enabled) {
				sr.size = new Vector2(
					transform.lossyScale.x != 0 ? (1f / transform.lossyScale.x) : 1f,
					transform.lossyScale.y != 0 ? (1f / transform.lossyScale.y) : 1f);
			}
		}
		if (pickable != null) {
			if (transform.localPosition != new Vector3(pickable.POS2D.x, pickable.POS2D.y, -pickable.RELATIVEZ)) {
				pickable.POS2D = new Vector2(transform.localPosition.x, transform.localPosition.y);

				if (pickable.RELATIVEZ != -transform.localPosition.z) {
					pickable.RELATIVEZ = -transform.localPosition.z;
					MapLoader.Loader.controller.zListManager.Sort(printMessages: false);
				}
			}
			if (transform.localEulerAngles.z != pickable.ANGLE.EulerAngle) {
				pickable.ANGLE.EulerAngle = transform.localEulerAngles.z;
			}
			if (Mathf.Abs(transform.localScale.x) != pickable.SCALE.x) {
				pickable.SCALE.x = Mathf.Abs(transform.localScale.x);
			}
			if (new Vector2(transform.localScale.x, transform.localScale.y) != new Vector2((pickable.xFLIPPED ? -1f : 1f) * pickable.SCALE.x, pickable.SCALE.y)) {
				pickable.SCALE = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
				pickable.xFLIPPED = transform.localScale.x < 0;
			}
		}
	}
	void UpdateGizmo() {
		Sprite spr = null;
		if (pickable != null) {
			Controller c = MapLoader.Loader.controller;
			TemplatePickable t = pickable.templatePickable;
			if (pickable is Frise) {
				if (t != null && t.TAGS != null) {
					foreach (string tag in t.TAGS) {
						Sprite sprLoc = c.GetIcon(tag);
						if (sprLoc == null) {
							print("Frieze: Untreated tag " + tag);
						}
						spr = sprLoc;
					}
				}
			} else if (pickable is Actor) {
				if (pickable is SubSceneActor) {
					SubSceneActor ssa = pickable as SubSceneActor;
					if (t != null && t.TAGS != null && t.TAGS.Count > 0) {
						foreach (string tag in t.TAGS) {
							Sprite sprLoc = c.GetIcon(tag);
							if (sprLoc == null) {
								print("SubSceneActor: Untreated tag " + tag);
							}
							spr = sprLoc;
						}
					}
					if (spr == null && ssa.RELATIVEPATH != null && !ssa.RELATIVEPATH.IsNull) {
						if (ssa.RELATIVEPATH.filename.EndsWith("_graph.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_graph");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_fx.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_fx");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_ld.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_ld");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_cine.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_cine");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_sound.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_sound");
						}
					}
					if (spr == null) {
						spr = MapLoader.Loader.controller.GetIcon("isc");
					}
				} else {
					if (t != null && t.TAGS != null && t.TAGS.Count > 0) {
						foreach (string tag in t.TAGS) {
							Sprite sprLoc = c.GetIcon(tag);
							if (sprLoc == null) {
								print("Actor: Untreated tag " + tag);
							}
							spr = sprLoc;
						}
					}
					if (spr == null) {
						spr = MapLoader.Loader.controller.GetIcon("actor");
					}
				}
			}
		}
		if (spr != null) {
			sr.sprite = spr;
		}
	}

	void CreateTexture() {
	}

	void CreateMesh() {
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.sortingLayerName = "Gizmo";
		sr.drawMode = SpriteDrawMode.Sliced;
		//sr.sharedMaterial = new Material(Shader.Find("Custom/Gizmo"));
		/*mr.sharedMaterial = unityMat;
		Mesh meshUnity = new Mesh();
		Vector3[] vertices = new Vector3[4];
		vertices[0] = new Vector3(0, -1, -1);
		vertices[1] = new Vector3(0, -1, 1);
		vertices[2] = new Vector3(0, 1, -1);
		vertices[3] = new Vector3(0, 1, 1);
		Vector3[] normals = new Vector3[4];
		normals[0] = Vector3.forward;
		normals[1] = Vector3.forward;
		normals[2] = Vector3.forward;
		normals[3] = Vector3.forward;
		Vector2[] uvs = new Vector2[4];
		uvs[0] = new Vector2(0, 0);
		uvs[1] = new Vector2(1, 0);
		uvs[2] = new Vector2(0, 1);
		uvs[3] = new Vector2(1, 1);
		int[] triangles = new int[] { 0, 2, 1, 1, 2, 3 };

		meshUnity.vertices = vertices;
		meshUnity.normals = normals;
		meshUnity.triangles = triangles;
		meshUnity.uv = uvs;


		mf.mesh = meshUnity;*/
	}
}
