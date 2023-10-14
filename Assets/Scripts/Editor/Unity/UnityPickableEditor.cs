using UnityEditor;
using UbiArt;
using UnityEngine;

[CustomEditor(typeof(UnityPickable))]
public class UnityPickableEditor : Editor {
	private static bool ShowParentBind = false;

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		UnityPickable p = target as UnityPickable;
		if (p != null && p.pickable != null) {
			if (p.pickable.templatePickable != null) {
				if (p.pickable is UbiArt.ITF.Frise f) {
					EditorGUILayout.TextField("FriseConfig", (string)(f?.ConfigName?.FullPath));
				} else if (p.pickable is UbiArt.ITF.Actor a) {
					EditorGUILayout.TextField("LUA", (string)(a?.LUA?.FullPath));
				}
				if (p.pickable is UbiArt.ITF.Actor act &&
					(Controller.MainContext?.Settings?.Game == Game.RA || Controller.MainContext?.Settings?.Game == Game.RM
					|| !(p.pickable is UbiArt.ITF.Frise))) {
					ShowParentBind = EditorGUILayout.Foldout(ShowParentBind, "parentBind");
					if (ShowParentBind) {
						EditorGUI.indentLevel++;
						act.parentBind.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "parentBind");
						EditorGUI.indentLevel--;
					}
				}
			}
			if (p.pickable.templatePickable != null && p.pickable.templatePickable.TAGS != null) {
				p.pickable.templatePickable.TAGS.Serialize(CSerializerObjectUnityEditor.Serializer(Controller.MainContext), "TAGS");
			}
		}

	}
}