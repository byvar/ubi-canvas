using UnityEditor;
using UbiArt;
using UnityEngine;
using System.Linq;

[CustomEditor(typeof(UnityAnimation))]
public class UnityAnimationEditor : Editor {

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		UnityAnimation ua = target as UnityAnimation;
		if (ua != null && ua.anims != null) {
			int newInd = EditorGUILayout.Popup("Animations", ua.animIndex, ua.anims.Select(a => a.Path.filename).ToArray());
			GUILayout.BeginHorizontal();
			GUI.enabled = newInd > 0;
			if (GUILayout.Button("Previous")) newInd--;
			GUI.enabled = (newInd < ua.anims.Length - 1);
			if (GUILayout.Button("Next")) newInd++;
			GUI.enabled = true;
			GUILayout.EndHorizontal();
			if (ua.animIndex != newInd) {
				ua.animIndex = newInd;
				ua.Init();
			}
		}

	}
}