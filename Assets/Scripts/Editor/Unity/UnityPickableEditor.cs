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
				var s = CSerializerObjectUnityEditor.Serializer(Controller.MainContext);

				if (p.pickable is UbiArt.ITF.Actor act &&
					(Controller.MainContext?.Settings?.Game == Game.RA || Controller.MainContext?.Settings?.Game == Game.RM
					|| !(p.pickable is UbiArt.ITF.Frise))) {
					ShowParentBind = EditorGUILayout.Foldout(ShowParentBind, "parentBind");
					if (ShowParentBind) {
						EditorGUI.indentLevel++;
						act.parentBind.Serialize(s, "parentBind");
						EditorGUI.indentLevel--;
					}
				}
				if (p.pickable is UbiArt.ITF.Actor act2 &&
					(Controller.MainContext?.Settings?.Game == Game.RA || Controller.MainContext?.Settings?.Game == Game.RM)) {
					act2.STARTPAUSE = s.Serialize<bool>(act2.STARTPAUSE, name: "STARTPAUSE");
				}
				if (p.pickable.templatePickable.TAGS != null) {
					p.pickable.templatePickable.TAGS.Serialize(s, "TAGS");
				}
			}
		}

	}
}