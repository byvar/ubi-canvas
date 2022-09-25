using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityFrise))]
public class UnityFriseEditor : Editor {
	/*Color proColor = (Color)new Color32(56, 56, 56, 255);
	Color plebColor = (Color)new Color32(194, 194, 194, 255);
	protected override void OnHeaderGUI() {
		var rect = EditorGUILayout.GetControlRect(false, 0f);
		rect.height = EditorGUIUtility.singleLineHeight;
		rect.y -= rect.height;
		rect.x = 48;
		rect.xMax -= rect.x * 2f;

		EditorGUI.DrawRect(rect, EditorGUIUtility.isProSkin ? proColor : plebColor);

		UnityActorComponent uac = target as UnityActorComponent;
		if (uac != null && uac.component != null && !uac.component.IsNull) {
			string header = uac.component.obj.GetType().Name;
			EditorGUI.LabelField(rect, header, EditorStyles.boldLabel);
		} else {

			EditorGUI.LabelField(rect, "ActorComponent", EditorStyles.boldLabel);
		}
	}*/

	public override void OnInspectorGUI() {
		//DrawDefaultInspector();
		//OnHeaderGUI();

		UnityFrise frise = target as UnityFrise;
		if (frise != null && frise.frise != null) {
			frise.frise.Serialize(CSerializerObjectUnityEditor.Serializer(MapLoader.Loader), "Frise");
		}

	}
}