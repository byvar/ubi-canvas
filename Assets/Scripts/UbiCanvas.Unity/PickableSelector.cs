using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class PickableSelector : MonoBehaviour {
	public Controller controller;
	public CameraComponent cam;

	public UnityPickable highlighted;
	public UnityPickable selected;

	public bool IsSelecting { get; private set; } = false;

    private void HandleCollision() {
        /*int layerMask = 0;
        layerMask |= 1 << LayerMask.NameToLayer("Visual");*/
        int layerMask = -1;

        Ray ray = cam.cam.ScreenPointToRay(UnityEngine.Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray, Mathf.Infinity, layerMask, QueryTriggerInteraction.Ignore);
        if (hits != null && hits.Length > 0) {
            System.Array.Sort(hits, (x, y) => (x.distance.CompareTo(y.distance)));
            var friseEditor = FindObjectOfType<FriseEditorBehaviour>();
            if (controller.displayGizmos) {
                for (int i = 0; i < hits.Length; i++) {
                    // the object identified by hit.transform was clicked
                    FriseEditorPointBehaviour frisePoint = hits[i].transform.GetComponentInParent<FriseEditorPointBehaviour>();
                    if (frisePoint != null) {
                        if (UnityEngine.Input.GetMouseButtonDown(0)) {
                            IsSelecting = true;
                        }
                        if (IsSelecting) {
                            if (cam.IsPanningWithThreshold()) {
                                IsSelecting = false;
                            } else {
                                friseEditor.SelectedPoint = frisePoint;
                            }
                        }
                        break;
                    }
                    UnityPickable pb = hits[i].transform.GetComponentInParent<UnityPickable>();
                    if (pb != null) {
                        highlighted = pb;
                        if (UnityEngine.Input.GetMouseButtonDown(0)) {
                            IsSelecting = true;
                        }
                        //UpdateHighlight();
                        if (IsSelecting) {
                            if (cam.IsPanningWithThreshold()) {
                                IsSelecting = false;
                            } else if (UnityEngine.Input.GetMouseButtonUp(0)) {
                                Select(pb, view: true);
                            }
                        }
                        break;
                    }
                }
            }
        }
    }

    public void Select(UnityPickable p, bool view = false) {
        if (selected != p || view) {
            Deselect();
            selected = p;
            p.Select();
#if UNITY_EDITOR
            UnityEditor.Selection.activeGameObject = p.gameObject;
#endif
            cam.JumpTo(p.gameObject, frontView: true);
        }
    }

    public void Deselect() {
        if (selected != null) {
            selected.Deselect();
        }
        selected = null;
    }
    private void UpdateHighlight() {
        //outline.Highlight = highlightedPerso != null ? highlightedPerso.gameObject : null;
        //outline.selecting = IsSelecting;
    }
    void Update() {
        highlighted = null;
        UpdateHighlight();
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        if (!cam.MouseLookEnabled && !cam.MouseLookRMBEnabled
            && GlobalLoadState.LoadState == GlobalLoadState.State.Finished
            && screenRect.Contains(UnityEngine.Input.mousePosition)) HandleCollision();
        if (IsSelecting && !UnityEngine.Input.GetMouseButton(0)) {
            IsSelecting = false;
        }
    }
}
