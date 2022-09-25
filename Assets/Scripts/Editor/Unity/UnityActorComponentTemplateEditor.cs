using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityActorComponentTemplate))]
public class UnityActorComponentTemplateEditor : Editor {
	UnityEngine.Color proColor = (UnityEngine.Color)new Color32(56, 56, 56, 255);
	UnityEngine.Color plebColor = (UnityEngine.Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		UnityActorComponentTemplate uac = target as UnityActorComponentTemplate;
		if (uac != null && uac.component != null) {
			string header = uac.component.GetType().Name;
			EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
		} else {

			EditorGUI.LabelField(rect, "ActorComponent (Template)", EditorStyles.boldLabel);
		}
	}

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		OnHeaderGUI();

		UnityActorComponentTemplate uac = target as UnityActorComponentTemplate;
		if (uac != null && uac.component != null) {
			uac.component.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "ActorComponent_Template");
		}

	}
}