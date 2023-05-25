using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UbiCanvas.Tools;
using UnityEditor;
using UnityEngine;

public class UnityWindowTools : UnityWindow 
{
	[MenuItem("Ubi-Canvas/Game Tools")]
	public static void ShowWindow() => GetWindow<UnityWindowTools>("Game Tools");

	private void OnEnable() 
	{
		titleContent = EditorGUIUtility.IconContent("CustomTool");
		titleContent.text = "Game Tools";
	}

	private async void OnGUI() {
		Task currentTask = null;
		EditorStyles.label.wordWrap = true;

		foreach (GameTool tool in GameTools.Tools)
		{
			if (!_toolFoldouts.ContainsKey(tool))
				_toolFoldouts.Add(tool, false);

			bool foldout = _toolFoldouts[tool] = EditorGUILayout.BeginFoldoutHeaderGroup(_toolFoldouts[tool], tool.Name);

			if (foldout)
			{
				string descr = tool.Description;

				if (descr != null)
					EditorGUILayout.LabelField(descr);

				var notMetRequirements = tool.Requirements.Select(x => x.IsAvailable()).Where(x => !x.IsAvailable).ToList();

				if (notMetRequirements.Any())
				{
					EditorGUILayout.HelpBox("The tool can not run due to the following requirements not being met:" +
					                        $"{Environment.NewLine}" +
					                        $"{String.Join(Environment.NewLine, notMetRequirements.Select(x => $"- {x.RequirementText}"))}", MessageType.Info);

					EditorGUILayout.EndFoldoutHeaderGroup();
					continue;
				}

				var newTask = ShowGameToolGUI(tool);
				if(newTask != null) currentTask = newTask;
			}

			EditorGUILayout.EndFoldoutHeaderGroup();
		}
		if (currentTask != null) {
			await currentTask.AsUniTask();
		}
	}

	private Task ShowGameToolGUI(GameTool tool)
	{
		Task task = null;
		if (tool is ActionGameTool actionGameTool)
		{
			if (GUI.Button(EditorGUILayout.GetControlRect(), new GUIContent("Run action")))
				task = actionGameTool.InvokeAsync();
		}
		else if (tool is ExportActionGameTool exportActionGameTool)
		{
			if (GUI.Button(EditorGUILayout.GetControlRect(), new GUIContent("Export")))
			{
				string outputDir = EditorUtility.OpenFolderPanel("Select output directory", null, "");
				
				if (!String.IsNullOrWhiteSpace(outputDir))
					task = exportActionGameTool.InvokeAsync(outputDir);
			}
		}
		else if (tool is BuildModIPKTool buildModIPKTool)
		{

			foreach (MultiActionGameTool.InvokableAction invokableAction in buildModIPKTool.Actions) {
				if (GUI.Button(EditorGUILayout.GetControlRect(), new GUIContent(invokableAction.Name)))
					task = invokableAction.Action();
			}
		}
		else if (tool is MultiActionGameTool multiActionGameTool)
		{
			foreach (MultiActionGameTool.InvokableAction invokableAction in multiActionGameTool.Actions)
			{
				if (GUI.Button(EditorGUILayout.GetControlRect(), new GUIContent(invokableAction.Name)))
					task = invokableAction.Action();
			}
		}
		else
		{
			EditorGUILayout.HelpBox($"The tool type {tool.GetType().Name} does not have a supported UI", MessageType.Error);
		}
		return task;
	}

	private readonly Dictionary<GameTool, bool> _toolFoldouts = new();
}