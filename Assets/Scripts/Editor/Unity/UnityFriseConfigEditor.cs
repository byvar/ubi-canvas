using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityFriseConfig))]
public class UnityFriseConfigEditor : Editor {
	Color proColor = (Color)new Color32(56, 56, 56, 255);
	Color plebColor = (Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		string header = "Frise Config (Shared)";
		EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnityFriseConfig fcg = target as UnityFriseConfig;
		if (fcg != null && fcg.friseConfig != null) {
			fcg.friseConfig.Serialize(CSerializerObjectUnityEditor.Serializer, "FriseConfig");
		}

	}
}