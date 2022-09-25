using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityActorTemplate))]
public class UnityActorTemplateEditor : Editor {
	UnityEngine.Color proColor = (UnityEngine.Color)new Color32(56, 56, 56, 255);
	UnityEngine.Color plebColor = (UnityEngine.Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		string header = "Actor Template (Shared)";
		EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnityActorTemplate tpl = target as UnityActorTemplate;
		if (tpl != null && tpl.template != null) {
			tpl.template.Serialize(CSerializerObjectUnityEditor.Serializer(MapLoader.Loader), "Template");
		}

	}
}