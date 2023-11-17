using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using System.Linq;
using UbiCanvas.Helpers;

public class UnityPickable : MonoBehaviour {
	public Pickable pickable;
	private SpriteRenderer sr;
	private SphereCollider sc;
	public Scene ContainingScene;
	private bool inited = false;

	private void Init() {
		inited = true;
		CreateMesh();
		UpdateGizmo();
	}

	private void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		if (!inited) Init();
		if (sr != null) {
			sr.enabled = Controller.Obj.displayGizmos;
			sc.enabled = sr.enabled;
			if (sr.enabled) {
				sr.size = new Vector2(
					transform.lossyScale.x != 0 ? (1f / transform.lossyScale.x) : 1f,
					transform.lossyScale.y != 0 ? (1f / transform.lossyScale.y) : 1f);
				sc.radius = sr.size.magnitude * 0.2f;
			}
		}
		if (pickable != null) {
			if (pickable.USERFRIENDLY != gameObject.name) {
				pickable.USERFRIENDLY = gameObject.name;
			}
			if (transform.localPosition != new Vector3(pickable.POS2D.x, pickable.POS2D.y, -pickable.RELATIVEZ)) {
				pickable.POS2D = new Vec2d(transform.localPosition.x, transform.localPosition.y);

				if (pickable.RELATIVEZ != -transform.localPosition.z) {
					pickable.RELATIVEZ = -transform.localPosition.z;
					Controller.Obj.zListManager.Sort(printMessages: false);
				}
			}
			if (transform.localEulerAngles.z != pickable.ANGLE.EulerAngle) {
				pickable.ANGLE.EulerAngle = transform.localEulerAngles.z;
			}
			if (Mathf.Abs(transform.localScale.x) != pickable.SCALE.x) {
				pickable.SCALE.x = Mathf.Abs(transform.localScale.x);
			}
			if (new Vector2(transform.localScale.x, transform.localScale.y) != new Vector2((pickable.xFLIPPED ? -1f : 1f) * pickable.SCALE.x, pickable.SCALE.y)) {
				pickable.SCALE = new Vec2d(Mathf.Abs(transform.localScale.x), transform.localScale.y);
				pickable.xFLIPPED = transform.localScale.x < 0;
			}
			if (ContainingScene != null && transform.parent.gameObject != null) {
				var parentScene = transform.parent.gameObject.GetComponent<UnityScene>();
				if (parentScene != null && parentScene.scene != ContainingScene) {
					RemoveFromContainingScene();
					ContainingScene = parentScene.scene;
					AddToContainingScene();
				}
			}
		}
	}

	void UpdateGizmo(bool selected = false) {
		Sprite spr = null;
		if (pickable != null) {
			Controller c = Controller.Obj;
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
				if (spr == null) {
					spr = c.GetIcon("frieze", selected);
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
							spr = c.GetIcon("isc_graph", selected);
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_fx.isc")) {
							spr = c.GetIcon("isc_fx", selected);
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_ld.isc")) {
							spr = c.GetIcon("isc_ld", selected);
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_cine.isc")) {
							spr = c.GetIcon("isc_cine", selected);
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_sound.isc")) {
							spr = c.GetIcon("isc_sound", selected);
						}
					}
					if (spr == null) {
						spr = c.GetIcon("isc", selected);
					}
				} else {
					if (t != null && t.TAGS != null && t.TAGS.Count > 0) {
						foreach (string tag in t.TAGS) {
							if(string.IsNullOrWhiteSpace(tag)) continue;
							Sprite sprLoc = c.GetIcon(tag, selected);
							if (sprLoc == null) {
								print("Actor: Untreated tag " + tag);
							}
							spr = sprLoc;
						}
					}
					if (spr == null) {
						spr = c.GetIcon("actor", selected);
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

	public void Deselect() {
		UpdateGizmo(false);
	}
	public void Select() {
		UpdateGizmo(true);
	}

	public void OnDestroy() {
		RemoveFromContainingScene();
	}

	void RemoveFromContainingScene() {
		if (ContainingScene != null && pickable != null) {
			ContainingScene.DeletePickable(pickable);
		}
	}

	void AddToContainingScene() {
		if (ContainingScene != null && pickable != null) {
			if (pickable is Frise f) {
				if (ContainingScene.FRISE == null) ContainingScene.FRISE = new CListO<Frise>();
				if (!ContainingScene.FRISE.Contains(f)) {
					ContainingScene.FRISE.Add(f);
				}
			} else if (pickable is Actor a) {
				if (ContainingScene.ACTORS == null) ContainingScene.ACTORS = new CArrayO<Generic<Actor>>();
				if (!ContainingScene.ACTORS.Any(act => act?.obj == a)) {
					ContainingScene.ACTORS.Add(new Generic<Actor>(a));
				}
			}
		}
	}

	void CreateMesh() {
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.sortingLayerName = "Gizmo";
		sr.drawMode = SpriteDrawMode.Sliced;
		sc = gameObject.AddComponent<SphereCollider>();
		sc.radius = 0.2f;
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
