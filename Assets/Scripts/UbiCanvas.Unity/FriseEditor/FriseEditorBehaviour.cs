using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;
using UnityEngine.UI;

public class FriseEditorBehaviour : MonoBehaviour {
	public Controller controller;
	public Material lineMaterial;
	private UnityPickable currentSelectedObject;
	private FriseEditorPointBehaviour[] Points { get; set; }

	private FriseEditorPointBehaviour _selectedPoint;
	public FriseEditorPointBehaviour SelectedPoint {
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
		var fr = currentSelectedObject.GetComponent<UnityFrise>();
		if (fr != null) {
			var pointsList = fr.frise.PointsList?.LocalPoints ?? fr.frise.LOCAL_POINTS;
			var loop = ((fr.frise.UbiArtContext?.Settings?.EngineVersion > EngineVersion.RO) ? fr.frise.PointsList?.Loop : fr.frise.LOOP) ?? true;
			var frTransform = fr.gameObject.transform;
			Points = new FriseEditorPointBehaviour[pointsList.Count];

			for (int i = 0; i < Points.Length; i++) {
				var edge = pointsList[i];
				var gao = new GameObject($"Point {i}");
				gao.transform.SetParent(transform, false);
				gao.transform.localPosition = frTransform.TransformPoint(new Vector3(edge.POS.x, edge.POS.y, 0));
				gao.transform.localScale = Vector3.one;
				gao.transform.localRotation = Quaternion.identity;

				var frp = gao.AddComponent<FriseEditorPointBehaviour>();
				frp.controller = controller;
				frp.editor = this;
				frp.Data = edge;
				Points[i] = frp;
			}
			for (int i = 0; i < Points.Length; i++) {
				if (i + 1 < Points.Length) {
					Points[i].target = Points[i + 1];
				} else if (loop) {
					Points[i].target = Points[0];
				}
				Points[i].Init();
			}
		}
	}
}
