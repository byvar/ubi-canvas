﻿using UnityEditor;
using UbiArt;
using UnityEngine;
using UbiCanvas.Helpers;

[CustomEditor(typeof(UnityGenericObject))]
public class UnityGenericObjectEditor : Editor {
	UnityEngine.Color proColor = (UnityEngine.Color)new Color32(56, 56, 56, 255);
	UnityEngine.Color plebColor = (UnityEngine.Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		UnityGenericObject ugo = target as UnityGenericObject;
		if (ugo != null && ugo.obj != null) {
			string header = ugo.obj.GetType().GetFormattedName();
			EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
		} else {
			EditorGUI.LabelField(rect, "Unity Generic Object (null)", EditorStyles.boldLabel);
		}
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnityGenericObject ugo = target as UnityGenericObject;
		if (ugo != null && ugo.obj != null) {
			ugo.obj.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "UnityGenericObject");
		}

	}
}