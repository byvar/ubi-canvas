using UnityEditor;
using UbiArt;
using UnityEngine;
using System.Linq;

[CustomEditor(typeof(UnityAnimMeshVertex))]
public class UnityAnimMeshVertexEditor : Editor {

	public override void OnInspectorGUI() {
		DrawDefaultInspector();

		UnityAnimMeshVertex ua = target as UnityAnimMeshVertex;
		if (ua != null && ua.anims != null) {
			int newInd = EditorGUILayout.Popup("Animations", ua.animIndex, ua.anims.Select(a => a.Name).ToArray());
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