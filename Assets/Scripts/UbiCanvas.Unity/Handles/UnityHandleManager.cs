using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class UnityHandleManager : MonoBehaviour {
	public Controller controller;
	public Material lineMaterial;
	private UnityPickable currentSelectedObject;
	private UnityHandle[] Points { get; set; }

	private UnityHandle _selectedPoint;
	public UnityHandle SelectedPoint {
		get => _selectedPoint;
		set {
			if(_selectedPoint != null) _selectedPoint.Deselect();
			_selectedPoint = value;
			if(_selectedPoint != null) _selectedPoint.Select();
		}
	}

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
			if (currentSelectedObject != controller.SelectedObject) {
				DestroyPoints();
				currentSelectedObject = controller.SelectedObject;
				CreatePoints();
			}
		}
	}

	public void DestroyPoints() {
		if (Points != null) {
			foreach (var pt in Points) if(pt != null) Destroy(pt.gameObject);
			Points = null;
		}
	}
	public void CreatePoints() {
		if(currentSelectedObject == null) return;

		// Search for Frise
		var fr = currentSelectedObject.GetComponent<UnityFrise>();
		if (fr != null) {
			var pointsList = fr.frise.PointsList?.LocalPoints ?? fr.frise.LOCAL_POINTS;
			var loop = ((fr.frise.UbiArtContext?.Settings?.EngineVersion > EngineVersion.RO) ? fr.frise.PointsList?.Loop : fr.frise.LOOP) ?? true;
			var frTransform = fr.gameObject.transform;
			Points = new UnityHandle[pointsList.Count];

			for (int i = 0; i < Points.Length; i++) {
				if (pointsList[i] == null) pointsList[i] = new PolyLineEdge();
				var edge = pointsList[i];
				var gao = new GameObject($"Point {i}");
				gao.transform.SetParent(transform, false);
				gao.transform.localPosition = frTransform.TransformPoint(new Vector3(edge.POS?.x ?? 0, edge.POS?.y ?? 0, 0));
				gao.transform.localScale = Vector3.one;
				gao.transform.localRotation = Quaternion.identity;

				var frp = gao.AddComponent<FriseEditorPointHandle>();
				frp.manager = this;
				frp.Data = edge;
				Points[i] = frp;
			}
			for (int i = 0; i < Points.Length; i++) {
				if (i + 1 < Points.Length) {
					((FriseEditorPointHandle)Points[i]).target = (FriseEditorPointHandle)Points[i + 1];
				} else if (loop) {
					((FriseEditorPointHandle)Points[i]).target = (FriseEditorPointHandle)Points[0];
				}
				Points[i].Init();
			}
			return;
		}

		// Search for Bezier renderer
		foreach (Transform tf in currentSelectedObject.transform) {
			var bez = tf.GetComponent<UnityBezierRenderer>();
			if (bez != null) {
				var positions = bez.GetPositions().ToArray();
				Points = new UnityHandle[positions.Length];
				for (int i = 0; i < positions.Length / 2; i++) {
					// Position
					var gao = new GameObject($"Point {i}");
					gao.transform.SetParent(transform, false);
					gao.transform.localPosition = tf.TransformPoint(positions[i*2].GetUnityVector(invertZ: true));
					gao.transform.localScale = Vector3.one;
					gao.transform.localRotation = Quaternion.identity;

					var frp = gao.AddComponent<UnityBezierPointHandle>();
					frp.Node = bez.Branch.nodes[i];

					if (i > 0) {
						frp.RelativeTransform = Points[(i-1)*2].transform;
					} else {
						frp.RelativeTransform = bez.transform;
					}

					frp.manager = this;
					Points[i*2] = frp;
					frp.Init();

					// Tangent
					gao = new GameObject($"Point {i} - Tangent");
					gao.transform.SetParent(transform, false);
					gao.transform.localPosition = tf.TransformPoint(positions[i*2 + 1].GetUnityVector(invertZ: true));
					gao.transform.localScale = Vector3.one;
					gao.transform.localRotation = Quaternion.identity;

					frp = gao.AddComponent<UnityBezierPointHandle>();
					frp.Node = bez.Branch.nodes[i];

					frp.RelativeTransform = Points[i * 2].transform;
					frp.MainPoint = (UnityBezierPointHandle)Points[i * 2];

					frp.manager = this;
					Points[i * 2 + 1] = frp;
					frp.Init();
				}
			}
		}
	}
}
