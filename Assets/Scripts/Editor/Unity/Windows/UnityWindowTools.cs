using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UbiCanvas.Helpers;
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

	protected override void UpdateEditorFields() {
		base.UpdateEditorFields();

		foreach (GameTool tool in GameTools.Tools)
		{
			if (!_toolFoldouts.ContainsKey(tool))
				_toolFoldouts.Add(tool, false);

			bool foldout = _toolFoldouts[tool] = EditorGUI.BeginFoldoutHeaderGroup(GetNextRect(ref YPos, vPadding: 2), _toolFoldouts[tool], tool.Name);

			if (foldout)
			{
				string descr = tool.Description;

				if (descr != null)
					EditorGUI.LabelField(GetNextRect(ref YPos, vPaddingBottom: 4), descr, EditorStyles.miniLabel);

				var notMetRequirements = tool.Requirements.Select(x => x.IsAvailable()).Where(x => !x.IsAvailable).ToList();

				if (notMetRequirements.Any())
				{
					EditorHelpBox("The tool can not run due to the following requirements not being met:" +
					                        $"{Environment.NewLine}" +
					                        $"{String.Join(Environment.NewLine, notMetRequirements.Select(x => $"- {x.RequirementText}"))}", MessageType.Warning,
											rect: GetNextRect(ref YPos, linesCount: (notMetRequirements.Count + 1)));

					EditorGUI.EndFoldoutHeaderGroup();
					continue;
				}

				ShowGameToolGUI(tool);
			}

			EditorGUI.EndFoldoutHeaderGroup();
		}
	}

	private void ShowGameToolGUI(GameTool tool) {
		if (tool is ActionGameTool actionGameTool)
		{
			if(EditorButton("Run action"))
				ExecuteTask(actionGameTool.InvokeAsync());
		}
		else if (tool is ExportActionGameTool exportActionGameTool)
		{
			if (EditorButton("Export"))
			{
				string outputDir = EditorUtility.OpenFolderPanel("Select output directory", null, "");
				
				if (!String.IsNullOrWhiteSpace(outputDir))
					ExecuteTask(exportActionGameTool.InvokeAsync(outputDir));
			}
		}
		else if (tool is BuildModIPKTool buildModIPKTool)
		{
			EditorGUI.BeginChangeCheck();

			UnitySettings.Tools_BuildModIPK_GameMode = EditorField<UbiArt.Settings.Mode>("Game", UnitySettings.Tools_BuildModIPK_GameMode);

			UnitySettings.Tools_BuildModIPK_InputPath = DirectoryField(GetNextRect(ref YPos), "Input path (raw files)", UnitySettings.Tools_BuildModIPK_InputPath, true);
			UnitySettings.Tools_BuildModIPK_OutputPath = DirectoryField(GetNextRect(ref YPos), "Output path", UnitySettings.Tools_BuildModIPK_OutputPath, true);
			UnitySettings.Tools_BuildModIPK_OriginalBundlesPath = DirectoryField(GetNextRect(ref YPos), "Original bundles path", UnitySettings.Tools_BuildModIPK_OriginalBundlesPath, true);

			UnitySettings.Tools_BuildModIPK_CreateSecureFatAfterIPK = EditorField("Create secure_fat", UnitySettings.Tools_BuildModIPK_CreateSecureFatAfterIPK);
			UnitySettings.Tools_BuildModIPK_BundleBaseName = EditorField("Bundle base name", UnitySettings.Tools_BuildModIPK_BundleBaseName);
			UnitySettings.Tools_BuildModIPK_BundleOrder = EditorField("Bundle order", UnitySettings.Tools_BuildModIPK_BundleOrder);
			
			if (EditorGUI.EndChangeCheck()) {
				UnitySettings.Save();
			}

			foreach (MultiActionGameTool.InvokableAction invokableAction in buildModIPKTool.Actions) {
				if (EditorButton(invokableAction.Name))
					ExecuteTask(invokableAction.Action());
			}
		}
		else if(tool is AdventuresToLegendsModTool adventuresToLegendsModTool)
		{

			EditorGUI.BeginChangeCheck();

			UnitySettings.Tools_AdventuresToLegends_ProjectPath = DirectoryField(GetNextRect(ref YPos), "Project path", UnitySettings.Tools_AdventuresToLegends_ProjectPath, true);
			UnitySettings.Tools_AdventuresToLegends_GamePath = DirectoryField(GetNextRect(ref YPos), "Game path", UnitySettings.Tools_AdventuresToLegends_GamePath, true);

			if (EditorGUI.EndChangeCheck()) {
				UnitySettings.Save();
			}

			foreach (MultiActionGameTool.InvokableAction invokableAction in adventuresToLegendsModTool.Actions) {
				if (EditorButton(invokableAction.Name))
					ExecuteTask(invokableAction.Action());
			}
		}
		else if (tool is MultiActionGameTool multiActionGameTool)
		{
			foreach (MultiActionGameTool.InvokableAction invokableAction in multiActionGameTool.Actions)
			{
				if (EditorButton(invokableAction.Name))
					ExecuteTask(invokableAction.Action());
			}
		}
		else
		{
			EditorHelpBox($"The tool type {tool.GetType().Name} does not have a supported UI", MessageType.Error);
		}
	}

	private readonly Dictionary<GameTool, bool> _toolFoldouts = new();
}