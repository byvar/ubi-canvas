using System;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class PickableOutlineDisplay : MonoBehaviour {
	public Controller controller;

	public UnityPickable pickable;
	private LineRenderer lr;
	private Tooltip tooltip;

	public RectTransform UICanvas;
	public Tooltip TooltipPrefab;

	private LineRenderer[] links;

	public float alpha = 1f;

	private void UpdateLinks(LinkComponent linkComponent) {
		bool activateLinks = false;
		if (linkComponent != null && linkComponent.Children?.Count > 0) {
			var linkCount = linkComponent.Children?.Count ?? 0;
			if (links != null && linkCount != links.Length) {
				foreach (var lnk in links) {
					GameObject.Destroy(lnk.gameObject);
				}
				links = null;
			}
			if (links == null) {
				links = new LineRenderer[linkCount];
				for (int i = 0; i < links.Length; i++) {
					var gao = new GameObject($"Link {i}");
					gao.transform.SetParent(transform, false);
					links[i] = gao.AddComponent<LineRenderer>();
					links[i].material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
					links[i].useWorldSpace = true;
					links[i].widthMultiplier = 0.03f;
					links[i].sortingLayerName = "Gizmo-Line";
					var color = new UnityEngine.Color(0f, 1f, 0f, alpha);
					links[i].material.color = color;
					links[i].startColor = color;
					links[i].endColor = color;
					links[i].positionCount = 2;
					links[i].loop = false;
				}
			}

			var tree = new PickableTree(Controller.Obj.MainScene.obj);
			var path = Controller.Obj.MainScene.obj.FindPickable(p => p == pickable.pickable);

			if (path != null) {
				var curNode = tree.FollowObjectPath(path.Path, throwIfNotFound: false);
				if (curNode != null) {
					activateLinks = true;
					for (int i = 0; i < links.Length; i++) {
						var link = linkComponent.Children[i];
						var linkedNode = curNode.Parent.GetNodeWithObjectPath(link?.Path, throwIfNotFound: false);
						bool linkActive = linkedNode?.Pickable != null;
						SetLinkActive(i, linkActive);
						if (linkActive) {
							links[i].SetPositions(new Vector3[] {
								pickable.transform.position,
								linkedNode.Pickable.GetPrecreatedGameObject().transform.position
							});
						}
					}
				}
			}
		}
		void SetLinkActive(int i, bool active) {
			if (links[i].gameObject.activeSelf != active) links[i].gameObject.SetActive(active);
		}

		if (!activateLinks) {
			if (links != null) {
				for (int i = 0; i < links.Length; i++) {
					SetLinkActive(i, false);
				}
			}
		}
	}

    private void UpdateHighlight() {
		if (lr == null) {
			lr = gameObject.AddComponent<LineRenderer>();
			lr.material = new Material(FindObjectOfType<UnityHandleManager>().lineMaterial);
			lr.useWorldSpace = true;
			lr.widthMultiplier = 0.03f;
			lr.sortingLayerName = "Gizmo-Line";
			var color = new UnityEngine.Color(1f,1f,1f, alpha);
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
			if (pickable?.pickable is Actor act) {
				var linkComponent = act.GetComponent<LinkComponent>();
				UpdateLinks(linkComponent);
			} else {
				UpdateLinks(null);
			}
		} else {
			lr.enabled = false;
			lr.positionCount = 0;
			tooltip.Hide();
			UpdateLinks(null);
		}
    }
    void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
			UpdateHighlight();
		}
    }
}
