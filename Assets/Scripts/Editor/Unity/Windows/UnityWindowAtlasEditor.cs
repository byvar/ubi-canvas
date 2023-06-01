using System.Linq;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.UV;
using UbiCanvas.Helpers;
using UnityEditor;
using UnityEngine;
using Color = UnityEngine.Color;

public class UnityWindowAtlasEditor : UnityWindow {
	[MenuItem("Ubi-Canvas/Atlas Editor")]
	public static void ShowWindow() {
		GetWindow<UnityWindowAtlasEditor>("Atlas Editor");
	}
	private void OnEnable() {
		titleContent = EditorGUIUtility.IconContent("Image Icon");
		titleContent.text = "Atlas Editor";

		wantsMouseMove = true;
	}

	protected override void UpdateEditorFields() {
		base.UpdateEditorFields();

		if (EditorApplication.isPlaying) {
			if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished) {
				var c = Controller.MainContext;
				string[] extensions = new string[] {
					$"*.tga{(c.Settings.cooked ? ".ckd" : "")}",
					$"*.png{(c.Settings.cooked ? ".ckd" : "")}"
				};
				
				DrawHeader("Select texture");
				Rect rect = GetNextRect(vPaddingBottom: 4f);
				string buttonString = "No texture selected";
				if (SelectedTextureFile != null) {
					buttonString = System.IO.Path.GetFileName(SelectedTextureFile);
				}
				rect = EditorGUI.PrefixLabel(rect, new GUIContent("Texture"));
				if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
					string directory = (Controller.MainContext.BasePath + c.Settings.ITFDirectory).Replace(System.IO.Path.DirectorySeparatorChar, '/');
					if (!directory.EndsWith("/")) directory += "/";
					while (directory.Contains("//")) directory = directory.Replace("//", "/");

					if (recheckFiles || Dropdown == null || Dropdown.directory != directory || Dropdown.extensions == null || !Enumerable.SequenceEqual(Dropdown.extensions,extensions) || Dropdown.mode != c.Settings.mode) {
						Dropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState(), directory, extensions) {
							name = "Texture files",
							mode = c.Settings.mode
						};
						recheckFiles = false;
					}
					Dropdown.Show(rect);
				}
				if (Dropdown != null && Dropdown.selection != null) {
					SelectedTextureFile = Dropdown.selection;
					Dropdown.selection = null;
					Dirty = true;
				}
				if (!string.IsNullOrEmpty(SelectedTextureFile)) {
					EditorGUI.TextArea(GetNextRect(), SelectedTextureFile);
					EditorGUI.BeginDisabledGroup(string.IsNullOrEmpty(SelectedTextureFile));
					Path texPath = new Path(SelectedTextureFile);

					var cache = Controller.MainContext?.Cache?.Structs;
					if (cache != null && cache.ContainsKey(typeof(TextureCooked)) && cache[typeof(TextureCooked)].ContainsKey(texPath.stringID)) {
						var tex = cache[typeof(TextureCooked)][texPath.stringID] as TextureCooked;
						if (tex != null) {
							var unityTex = tex.GetUnityTexture(Controller.MainContext).Texture;
							if (unityTex != null) {
								var canvas = GetNextRect(height: 512, vPadding: 4);
								Event e = Event.current;
								Rect subcanvas;
								var aspectRatio = unityTex.width / (float)unityTex.height;
								var canvasRatio = canvas.width / (float)canvas.height;
								float ratioScale = canvasRatio / aspectRatio;
								if (ratioScale < 1f) {
									var newH = canvas.height * ratioScale;
									subcanvas = new Rect(canvas.x, canvas.y + (canvas.height - newH) / 2f, canvas.width, newH);
								} else if(ratioScale > 1f) {
									var newW = canvas.width / ratioScale;
									subcanvas = new Rect(canvas.x + (canvas.width - newW) / 2f, canvas.y, newW, canvas.height);
								} else
									subcanvas = canvas;

								EditorGUI.DrawRect(subcanvas, BackgroundColor);
								GUI.DrawTextureWithTexCoords(subcanvas,
									tex.GetUnityTexture(Controller.MainContext).Texture,
									new Rect(0, 0, 1, -1));

								Vector2 GetTexturePositionOnRect(Vector2 pos) {
									return subcanvas.position + pos * subcanvas.size;
								}

								if (tex.atlas != null) {
									var pointSize = 10;
									var lineSize = 0.1f;
									Handles.BeginGUI();
									var atlas = tex.atlas;
									foreach (var uvPair in atlas.uvData) {
										UVdata uvdata = uvPair.Value;
										foreach (var uv in uvdata.uvs) {
											var uvPos = GetTexturePositionOnRect(new Vector2(uv.x, uv.y));
											Handles.DrawSolidRectangleWithOutline(
												new Rect(
													uvPos.x - pointSize/2, uvPos.y - pointSize / 2, pointSize, pointSize), Color.blue, Color.white);
										}
										int count = uvdata.uvs.Count;
										if (count == 2) {
											var uv1 = uvdata.uvs[0];
											var uv2 = uvdata.uvs[1];
											var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
											var uvPos2 = GetTexturePositionOnRect(new Vector2(uv1.x, uv2.y));
											Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
											uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
											uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv1.y));
											Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
											uvPos1 = GetTexturePositionOnRect(new Vector2(uv2.x, uv1.y));
											uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
											Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
											uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv2.y));
											uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
											Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
										} else {
											bool drawn = false;
											if (atlas.uvParams != null && atlas.uvParams.ContainsKey(uvPair.Key)) {
												var uvp = atlas.uvParams[uvPair.Key];
												if (uvp.triangles != null && uvp.triangles.Any()) {
													drawn = true;
													foreach (var tri in uvp.triangles) {
														var uv1 = uvdata.uvs[tri.vertex1];
														var uv2 = uvdata.uvs[tri.vertex2];
														var uv3 = uvdata.uvs[tri.vertex3];
														var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
														var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
														var uvPos3 = GetTexturePositionOnRect(new Vector2(uv3.x, uv3.y));
														Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
														Handles.DrawDottedLine(uvPos2, uvPos3, lineSize);
														Handles.DrawDottedLine(uvPos3, uvPos1, lineSize);
													}
												}
											}
											if(!drawn) {
												for (int i = 0; i < count; i++) {
													var uv1 = uvdata.uvs[i];
													var uv2 = uvdata.uvs[(i + 1) % count];
													var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
													var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
													Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
												}
											}
										}
									}
									Handles.EndGUI();
								}
							}
						}
					} else {
						if (EditorButton("Load")) {
							async Task LoadTex() {
								Controller.MainContext.Loader.LoadTexture(texPath, t => {
								});
								await Controller.MainContext.Loader.LoadLoop();
							}
							ExecuteTask(
								Controller.Obj.AdditionalLoad(
									LoadTex()
								)
							);
						}
					}
					EditorGUI.EndDisabledGroup();
				}
			} else {
				EditorHelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorHelpBox("Please start the scene to use this window.", MessageType.Info);
		}
	}

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown Dropdown { get; set; }

	/// <summary>
	/// The selected texture file
	/// </summary>
	private string SelectedTextureFile { get; set; }

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown PBKDropdown { get; set; }

	/// <summary>
	/// The selected texture file
	/// </summary>
	private string SelectedPBKFile { get; set; }

	private bool recheckFiles = false;

	public Color BackgroundColor { get; set; } = new Color(0,0,0,0.2f);
}