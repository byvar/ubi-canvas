using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class FriseEditorBehaviour : MonoBehaviour {
	public Controller controller;
	private UnityPickable currentSelectedObject;
	private FriseEditorPointBehaviour[] Points { get; set; }

	private FriseEditorPointBehaviour _selectedPoint;
	public FriseEditorPointBehaviour SelectedPoint {
		get => _selectedPoint;
		set {
			if(_selectedPoint != null) _selectedPoint.Deselect();
			_selectedPoint = value;
		}
	}

	// Use this for initialization
	void Start() {
	}

	// Update is called once per frame
	void Update() {
		if (Controller.LoadState == Controller.State.Finished) {
			if (currentSelectedObject != controller.SelectedObject) {
				DestroyPoints();
				currentSelectedObject = controller.SelectedObject;
				CreatePoints();
			}
		}
	}

	public void DestroyPoints() {
		if (Points != null) {
			foreach (var pt in Points)
				Destroy(pt.gameObject);
			Points = null;
		}
	}
	public void CreatePoints() {
		var fr = currentSelectedObject.GetComponent<UnityFrise>();
		if (fr != null) {
			var points = fr.frise.PointsList?.LocalPoints;
			var frTransform = fr.gameObject.transform;
			Points = points.Select((p,i) => {
				var gao = new GameObject($"Point {i}");
				gao.transform.SetParent(transform, false);
				gao.transform.localPosition = frTransform.TransformPoint(new Vector3(p.POS.x, p.POS.y, 0));
				gao.transform.localScale = Vector3.one * p.Scale;
				gao.transform.localRotation = Quaternion.identity;

				var frp = gao.AddComponent<FriseEditorPointBehaviour>();
				frp.controller = controller;
				frp.editor = this;
				return frp;
			}).ToArray();
		}
	}
}
