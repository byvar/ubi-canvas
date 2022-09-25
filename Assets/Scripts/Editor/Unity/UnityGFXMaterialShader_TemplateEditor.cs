using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityGFXMaterialShader_Template))]
public class UnityGFXMaterialShader_TemplateEditor : Editor {
	UnityEngine.Color proColor = (UnityEngine.Color)new Color32(56, 56, 56, 255);
	UnityEngine.Color plebColor = (UnityEngine.Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		string header = "Shader Template (Shared)";
		EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnityGFXMaterialShader_Template sh = target as UnityGFXMaterialShader_Template;
		if (sh != null && sh.shader != null) {
			sh.shader.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "Shader");
		}

	}
}