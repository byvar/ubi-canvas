using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnitySceneConfig))]
public class UnitySceneConfigEditor : Editor {
	UnityEngine.Color proColor = (UnityEngine.Color)new Color32(56, 56, 56, 255);
	UnityEngine.Color plebColor = (UnityEngine.Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);
		
		UnitySceneConfig sc = target as UnitySceneConfig;
		if (sc != null && sc.config != null) {
			string header = sc.config.GetType().Name;
			EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
		} else {

			EditorGUI.LabelField(rect, "Scene Config", EditorStyles.boldLabel);
		}
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnitySceneConfig sc = target as UnitySceneConfig;
		if (sc != null && sc.config != null) {
			sc.config.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "SceneConfig");
		}

	}
}