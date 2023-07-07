using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Animation;
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

				DrawHeader("Select texture");
				DrawTextureSelection();

				if (!string.IsNullOrWhiteSpace(SelectedTextureFile)) {
					Path texPath = new Path(SelectedTextureFile);

					var cache = Controller.MainContext?.Cache?.Structs;
					if (cache != null && cache.ContainsKey(typeof(TextureCooked)) && cache[typeof(TextureCooked)].ContainsKey(texPath.stringID)) {
						var tex = cache[typeof(TextureCooked)][texPath.stringID] as TextureCooked;
						if (tex != null) {
							var unityTex = tex.GetUnityTexture(Controller.MainContext).Texture;
							if (unityTex != null) {
								var canvas = GetNextRect(height: 512, vPadding: 4);
								Event e = Event.current;
								Rect subcanvas = AdjustAspectRatio(canvas, unityTex.width, unityTex.height, centerVertically: false);
								YPos -= canvas.height - subcanvas.height;

								EditorGUI.DrawRect(subcanvas, BackgroundColor);
								/*GUI.DrawTextureWithTexCoords(subcanvas,
									tex.GetUnityTexture(Controller.MainContext).Texture,
									new Rect(0, 0, 1, -1));*/
								GUI.DrawTextureWithTexCoords(subcanvas,
									tex.GetUnityTexture(Controller.MainContext).Texture,
									new Rect(0, 0, 1, -1), AlphaBlending);

								var rects = DivideRectHorizontally(GetNextRect(), 2);
								AlphaBlending = EditorField("Alpha Blending", AlphaBlending, rect: rects[0]);
								if (EditorButton("Export as PNG", rect: rects[1])) {
									var defaultName = texPath.filename;
									defaultName = System.IO.Path.GetFileNameWithoutExtension(defaultName);
									string filePath = EditorUtility.SaveFilePanel("Output PNG file", "", defaultName, "png");

									if (!string.IsNullOrWhiteSpace(filePath))
										SaveAsPNG(tex, filePath, hasTransparency: AlphaBlending);
								}


								var rect = GetNextRect();
								rect = EditorGUI.PrefixLabel(rect, new GUIContent("UV Source"));
								CurrentTab = (Tab)GUI.Toolbar(rect, (int)CurrentTab, new string[] { "Atlas Container", "Patch Bank" });
								switch (CurrentTab) {
									case Tab.AtlasContainer:
										DrawAtlas(tex, subcanvas);
										break;
									case Tab.PatchBank:
										DrawPatchBankUI(tex, subcanvas);
										break;
								}
							}
						}
					} else {
						if (EditorButton("Load")) {
							async Task LoadTex() {
								Controller.MainContext.Loader.LoadTexture(texPath, t => {});
								await Controller.MainContext.Loader.LoadLoop();
							}
							ExecuteTask(
								Controller.Obj.AdditionalLoad(
									LoadTex()
								)
							);
						}
					}
				}
			} else {
				EditorHelpBox("Loading...\nTo use this window, please wait until everything has loaded.", MessageType.Warning);
			}
		} else {
			EditorHelpBox("Please start the scene to use this window.", MessageType.Info);
		}
	}

	Rect AdjustAspectRatio(Rect canvas, float width, float height, bool centerVertically = true) {
		Rect subcanvas;
		var aspectRatio = width / height;
		var canvasRatio = canvas.width / (float)canvas.height;
		float ratioScale = canvasRatio / aspectRatio;
		if (ratioScale < 1f) {
			var newH = canvas.height * ratioScale;
			if (centerVertically) {
				subcanvas = new Rect(canvas.x, canvas.y + (canvas.height - newH) / 2f, canvas.width, newH);
			} else {
				subcanvas = new Rect(canvas.x, canvas.y, canvas.width, newH);
			}
		} else if (ratioScale > 1f) {
			var newW = canvas.width / ratioScale;
			subcanvas = new Rect(canvas.x + (canvas.width - newW) / 2f, canvas.y, newW, canvas.height);
		} else
			subcanvas = canvas;
		return subcanvas;

	}

	void DrawAtlas(TextureCooked tex, Rect rect) {

		Vector2 GetTexturePositionOnRect(Vector2 pos) {
			return rect.position + pos * rect.size;
		}
		if (tex.atlas != null) {
			var pointSize = 6;
			var lineSize = 0.1f;
			Handles.BeginGUI();
			var atlas = tex.atlas;
			UnityEngine.Random.InitState(12675);
			foreach (var uvPair in atlas.uvData) {
				UVdata uvdata = uvPair.Value;
				var pointColor = UnityEngine.Random.ColorHSV(0f, 1f, 0.8f, 0.8f, 0.8f, 1f, 1f, 1f);
				foreach (var uv in uvdata.uvs) {
					var uvPos = GetTexturePositionOnRect(new Vector2(uv.x, uv.y));
					Handles.DrawSolidRectangleWithOutline(
						new Rect(
							uvPos.x - pointSize / 2, uvPos.y - pointSize / 2, pointSize, pointSize), pointColor, Color.white);
				}
				int count = uvdata.uvs.Count;
				if (count == 2) {
					using (new Handles.DrawingScope(pointColor)) {
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
					}
				} else {
					bool drawn = false;
					if (atlas.uvParams != null && atlas.uvParams.ContainsKey(uvPair.Key)) {
						var uvp = atlas.uvParams[uvPair.Key];
						if (uvp.triangles != null && uvp.triangles.Any()) {
							drawn = true;
							using (new Handles.DrawingScope(pointColor)) {
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
					}
					if (!drawn) {
						using (new Handles.DrawingScope(pointColor)) {
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
			}
			Handles.EndGUI();
		}
	}

	void DrawPatchBankUI(TextureCooked tex, Rect rect) {
		DrawPatchBankSelection();
		if (!string.IsNullOrWhiteSpace(SelectedPBKFile)) {
			Path pbkPath = new Path(SelectedPBKFile);

			var cache = Controller.MainContext?.Cache?.Structs;
			if (cache != null && cache.ContainsKey(typeof(AnimPatchBank)) && cache[typeof(AnimPatchBank)].ContainsKey(pbkPath.stringID)) {
				var pbk = cache[typeof(AnimPatchBank)][pbkPath.stringID] as AnimPatchBank;
				if (pbk != null) {
					DrawPatchBank(tex, rect, pbk);
					var buttonsRect = GetNextRect();
					buttonsRect = EditorGUI.PrefixLabel(buttonsRect, new GUIContent("Show template"));
					var initialX = buttonsRect.xMin;
					bool MiniButton(string label, bool pressed) {
						var buttonRect = RowEntryRect(ref buttonsRect, buttonsRect.height * 5, getNextRect: () => {
							var r = GetNextRect();
							r.xMin = initialX;
							return r;
						});
						var oldColor = GUI.backgroundColor;
						if(pressed) GUI.backgroundColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
						if (GUI.Button(buttonRect, new GUIContent(label), EditorStyles.miniButton)) {
							if(pressed) GUI.backgroundColor = oldColor;
							return true;
						}
						if (pressed) GUI.backgroundColor = oldColor;
						return false;
					}
					bool allShown = ShowTemplate.All(st => st.Value == true);
					var showTemplateCopy = ShowTemplate.ToArray();
					if (MiniButton("Show all", allShown)) {
						foreach(var entry in showTemplateCopy) ShowTemplate[entry.Key] = !allShown;
						showTemplateCopy = ShowTemplate.ToArray();
					}
					foreach (var entry in showTemplateCopy) {
						if (MiniButton($"{entry.Key:X8}", entry.Value)) {
							ShowTemplate[entry.Key] = !entry.Value;
						}
					}
				}
			} else {
				if (EditorButton("Load")) {
					async Task LoadPBK() {
						Controller.MainContext.Loader.LoadFile<AnimPatchBank>(pbkPath, t => {});
						await Controller.MainContext.Loader.LoadLoop();
					}
					ExecuteTask(
						Controller.Obj.AdditionalLoad(
							LoadPBK()
						)
					);
				}
			}
		}
	}

	void SaveAsPNG(TextureCooked tex, string outputPath, bool hasTransparency = true) {
		var tex2d = tex.GetUnityTexture(Controller.MainContext).Texture;
		byte[] png;
		if (hasTransparency) {
			png = tex2d.Copy(flipY: true).EncodeToPNG();
		} else {
			png = tex2d.Copy(removeTransparency: true, flipY: true).EncodeToPNG();
		}

		Util.ByteArrayToFile(outputPath, png);
	}

	void DrawPatchBank(TextureCooked tex, Rect rect, AnimPatchBank pbk) {

		Vector2 GetTexturePositionOnRect(Vector2 pos) {
			var size = rect.width; //Mathf.Max(rect.width, rect.height);
			return rect.position + pos * size;
		}
		if (pbk != null) {
			var pointSize = 6;
			var lineSize = 0.1f;
			Handles.BeginGUI();
			UnityEngine.Random.InitState(12675);
			for(int tpl_i = 0; tpl_i < pbk.templates.Count; tpl_i++) {
				var tpl = pbk.templates[tpl_i];
				var tplKey = pbk.templateKeys.GetKeyFromValue(tpl_i);
				if (!ShowTemplate.ContainsKey(tplKey)) {
					ShowTemplate[tplKey] = true;
				}
				if(!ShowTemplate[tplKey]) continue;

				Dictionary<Link, AnimPatchPoint> points = tpl.patchPoints.ToDictionary(p => p.key, p => p);
				var pointColor = UnityEngine.Random.ColorHSV(0f, 1f, 0.8f, 0.8f, 0.8f, 1f, 1f, 1f);
				foreach (var point in tpl.patchPoints) {
					var uvPos = GetTexturePositionOnRect(point.uv.GetUnityVector());
					Handles.DrawSolidRectangleWithOutline(
						new Rect(
							uvPos.x - pointSize / 2, uvPos.y - pointSize / 2, pointSize, pointSize), pointColor, Color.white);


					var normalTest = point.uv + (point.normal * 0.01f);
					var normalTestPos = GetTexturePositionOnRect(normalTest.GetUnityVector());
					Handles.DrawLine(uvPos, normalTestPos, lineSize);

				}
				int patchesCount = tpl.patches.Count;
				int curPatch = 0;

				using (new Handles.DrawingScope(pointColor)) {
					if (tpl.patchPoints.Count >= 2) {
						var pt1 = tpl.patchPoints[0];
						var pt2 = tpl.patchPoints[1];
						var uv1 = pt1.uv;
						var uv2 = pt2.uv;
						var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
						var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
						Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
					}
					if (tpl.patchPoints.Count >= 3) {
						var cnt = tpl.patchPoints.Count;
						var pt1 = tpl.patchPoints[cnt - 2];
						var pt2 = tpl.patchPoints[cnt - 1];
						var uv1 = pt1.uv;
						var uv2 = pt2.uv;
						var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
						var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
						Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
					}
				}

				foreach (var patch in tpl.patches) {
					using (new Handles.DrawingScope(pointColor)) {
						var count = patch.points.Length;
						if(count != 4) throw new System.Exception("Unexpected patch points count!");
						Vec2d[] controlPoints = AnimTemplate.GetPatchControlPoints(
							new Vec2d[] {
								points[patch.points[0]].uv,
								points[patch.points[2]].uv,
								points[patch.points[3]].uv,
								points[patch.points[1]].uv,
							},
							new Vec2d[] {
								points[patch.points[0]].normal,
								points[patch.points[2]].normal,
								points[patch.points[3]].normal,
								points[patch.points[1]].normal,
							});
						DrawCubicBezier(rect, controlPoints[0], controlPoints[1], controlPoints[2], controlPoints[3]);
						DrawCubicBezier(rect, controlPoints[4], controlPoints[5], controlPoints[6], controlPoints[7]);

						/*var pt1 = points[patch.points[(0 + 0) % count]];
						var pt2 = points[patch.points[(0 + 1) % count]];
						for (int i = 0; i < count - 2; i++) {
							var pt3 = points[patch.points[(i + 2) % count]];
							var uv1 = pt1.uv;
							var uv2 = pt2.uv;
							var uv3 = pt3.uv;
							var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
							var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
							var uvPos3 = GetTexturePositionOnRect(new Vector2(uv3.x, uv3.y));
							if (i == 0) {
								Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
							}
							Handles.DrawDottedLine(uvPos2, uvPos3, lineSize);
							Handles.DrawDottedLine(uvPos3, uvPos1, lineSize);
							pt1 = pt2;
							pt2 = pt3;
						}*/
						/*for (int i = 0; i < count - 1; i++) {
							var pt1 = points[patch.points[(i) % count]];
							var pt2 = points[patch.points[(i + 1) % count]];
							var uv1 = pt1.uv;
							var uv2 = pt2.uv;
							var uvPos1 = GetTexturePositionOnRect(new Vector2(uv1.x, uv1.y));
							var uvPos2 = GetTexturePositionOnRect(new Vector2(uv2.x, uv2.y));
							Handles.DrawDottedLine(uvPos1, uvPos2, lineSize);
						}*/
						curPatch++;
					}
				}

			}
			Handles.EndGUI();
		}
	}

	Vec2d CalculateCubicBezierPoint(float t, Vec2d p0, Vec2d p1, Vec2d p2, Vec2d p3) {
		float u = 1 - t;
		float tt = t * t;
		float uu = u * u;
		float uuu = uu * u;
		float ttt = tt * t;

		Vec2d p = p0 * uuu;
		p += p1 * 3f * uu * t;
		p += p2 * 3f * u * tt;
		p += p3 * ttt;

		return p;
	}
	void DrawCubicBezier(Rect rect, Vec2d p0, Vec2d p1, Vec2d p2, Vec2d p3) {

		Vector2 GetTexturePositionOnRect(Vector2 pos) {
			var size = rect.width; //Mathf.Max(rect.width, rect.height);
			return rect.position + pos * size;
		}
		var numPoints = 16;
		var lineSize = 0.1f;
		Vec2d[] points = Enumerable.Range(0, numPoints).Select(i => CalculateCubicBezierPoint(i / (float)(numPoints - 1), p0,p1,p2,p3)).ToArray();
		Vector2[] pointsConv = points.Select(p => GetTexturePositionOnRect(p.GetUnityVector())).ToArray();
		for (int i = 0; i < points.Length - 1; i++) {
			Handles.DrawDottedLine(pointsConv[i], pointsConv[i+1], lineSize);
		}
	}

	void DrawTextureSelection() {
		var c = Controller.MainContext;
		string[] extensions = new string[] {
			$"*.tga{(c.Settings.cooked ? ".ckd" : "")}",
			$"*.png{(c.Settings.cooked ? ".ckd" : "")}"
		};
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

			if (recheckFiles || Dropdown == null || Dropdown.directory != directory || Dropdown.extensions == null || !Enumerable.SequenceEqual(Dropdown.extensions, extensions) || Dropdown.mode != c.Settings.mode) {
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
			ResetPBK = true;
			Dropdown.selection = null;
			Dirty = true;
		}
		EditorGUI.TextArea(GetNextRect(), SelectedTextureFile);
	}

	void DrawPatchBankSelection() {
		var c = Controller.MainContext;
		string[] PBKextensions = new string[] {
			$"*.pbk{(c.Settings.cooked ? ".ckd" : "")}"
		};
		Rect rect = GetNextRect(vPaddingBottom: 4f);
		if (ResetPBK) {
			SelectedPBKFile = null;
			if(PBKDropdown != null) 
				PBKDropdown.selection = null;
			ResetPBK = false;
			ShowTemplate.Clear();
		}
		string buttonString = "No patch bank selected";
		if (SelectedPBKFile != null) {
			buttonString = System.IO.Path.GetFileName(SelectedPBKFile);
		}
		rect = EditorGUI.PrefixLabel(rect, new GUIContent("Patch Bank"));
		if (EditorGUI.DropdownButton(rect, new GUIContent(buttonString), FocusType.Passive)) {
			string directory = (Controller.MainContext.BasePath + c.Settings.ITFDirectory).Replace(System.IO.Path.DirectorySeparatorChar, '/');
			if (!directory.EndsWith("/")) directory += "/";
			while (directory.Contains("//")) directory = directory.Replace("//", "/");

			if (recheckFiles || PBKDropdown == null || PBKDropdown.directory != directory || PBKDropdown.extensions == null || !Enumerable.SequenceEqual(PBKDropdown.extensions, PBKextensions) || PBKDropdown.mode != c.Settings.mode) {
				PBKDropdown = new FileSelectionDropdown(new UnityEditor.IMGUI.Controls.AdvancedDropdownState(), directory, PBKextensions) {
					name = "Patch bank files",
					mode = c.Settings.mode
				};
				recheckFiles = false;
			}
			PBKDropdown.Show(rect);
		}
		if (PBKDropdown != null && PBKDropdown.selection != null) {
			SelectedPBKFile = PBKDropdown.selection;
			PBKDropdown.selection = null;
			Dirty = true;
		}
		EditorGUI.TextArea(GetNextRect(), SelectedPBKFile);
	}

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown Dropdown { get; set; }

	/// <summary>
	/// The selected texture file
	/// </summary>
	private string SelectedTextureFile { get; set; }


	public enum Tab {
		AtlasContainer,
		PatchBank
	}
	public Tab CurrentTab { get; set; }

	/// <summary>
	/// The file selection dropdown
	/// </summary>
	private FileSelectionDropdown PBKDropdown { get; set; }

	/// <summary>
	/// The selected texture file
	/// </summary>
	private string SelectedPBKFile { get; set; }

	private Dictionary<ulong, bool> ShowTemplate { get; set; } = new Dictionary<ulong, bool>();

	private bool recheckFiles = false;

	private bool ResetPBK { get; set; }
	public Color BackgroundColor { get; set; } = new Color(0,0,0,0.2f);

	public bool AlphaBlending { get; set; } = true;
}