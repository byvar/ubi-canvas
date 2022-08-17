using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UbiArt;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class FriseEditorPointBehaviour : MonoBehaviour {
	public Controller controller;
	public FriseEditorBehaviour editor;
	private SpriteRenderer sr;
	private SphereCollider sc;

	// Use this for initialization
	void Start() {
		CreateMesh();
		Init();
	}

	private void Init() {
		Deselect();
	}
	// Update is called once per frame
	void Update() {
		if (Controller.LoadState == Controller.State.Finished) {
		}
	}
	void CreateMesh() {
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.sortingLayerName = "Gizmo";
		sr.drawMode = SpriteDrawMode.Sliced;
		sc = gameObject.AddComponent<SphereCollider>();
		sc.radius = 0.2f;
	}
	private void OnMouseDown() {
		editor.SelectedPoint = this;
		Select();
	}

	public void Deselect() {
		var spr = controller.GetIcon("frieze_point");
		if (spr != null) {
			sr.sprite = spr;
		}
	}
	public void Select() {
		var spr = controller.GetIcon("frieze_point_s");
		if (spr != null) {
			sr.sprite = spr;
		}
	}
}
