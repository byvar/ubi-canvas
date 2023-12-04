
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class UnityAnimation : MonoBehaviour {
	public class UnityPatchBank {
		public StringID ID { get; set; }
		public StringID TextureID { get; set; }

		public AnimPatchBank PBK { get; set; }
		public UnityPatch[] Patches { get; set; }
		public TextureBankPath TextureBankPath { get; set; }
		public Path TexturePathOrigins { get; set; }
	}
	public class UnityPatch {
		public GameObject Object { get; set; }
		public SkinnedMeshRenderer Renderer { get; set; }
		public bool Active { get; set; }
	}
	public class UnityAnimationTrack {
		public StringID ID { get; set; }
		public Path Path { get; set; }
		public AnimTrack Track { get; set; }
		public SubAnim_Template SubAnim { get; set; }
	}
	//public AnimLightComponent animLightComponent;
	public AnimTrack animTrack => Animation?.Track;
	public UnityAnimationTrack Animation {
		get {
			if (anims != null && animIndex >= 0 && animIndex < anims.Length) {
				return anims[animIndex];
			}
			return null;
		}
	}
	public int animIndex = -1;
	public float currentBMLFrame = -1;
	public UnityAnimationTrack[] anims;
	public AnimSkeleton skeleton;
	public UnityBone[] bones;
	public UnityPatchBank[] AllPatchBanks;
	public Dictionary<StringID, UnityPatchBank> patchBanks; // Index: bank ID
	public Dictionary<StringID, UnityPatchBank> patchBanksOrigins; // Index: texture path StringID
	public AnimLightComponent alc;
	public AnimLightComponent_Template alc_tpl;
	public bool playAnimation = true;
	public bool DisplayPolylines;
	public bool DisplayInactivePolylines;
	public float animationSpeed = 30f;
	public int zValue = 0;
	bool loaded = false;
	private Dictionary<StringID, LineRenderer> lines;
	private GameObject linesGao;

	//private float updateCounter = 0f;
	public float currentFrame = 0;

	public void Start() {
	}
	public void Init() {
		Context l = Controller.MainContext;
		if (animIndex >= 0 && skeleton != null) {
			currentFrame = 0;
			currentBMLFrame = -1;
			skeleton.ResetBones(l, bones);
			InitLines();
			UpdateAnimation();
		}
		loaded = true;
	}

	public void InitLines() {
		if(linesGao == null) linesGao = new GameObject("Polylines");
		linesGao.SetActive(DisplayPolylines);
		linesGao.transform.SetParent(transform, false);
		linesGao.transform.localPosition = Vector3.zero;
		linesGao.transform.localScale = Vector3.one;
		linesGao.transform.localRotation = Quaternion.identity;

		if(lines == null) lines = new Dictionary<StringID, LineRenderer>();
		if (lines.Any()) {
			foreach (var l in lines) {
				Destroy(l.Value.gameObject);
			}
		}
		lines.Clear();
		if ((skeleton?.bank?.value?.polylines?.Count ?? 0) > 0) {
			foreach (var l in skeleton?.bank?.value?.polylines) {
				var lr = new GameObject($"Polyline {l.name}").AddComponent<LineRenderer>();
				lr.material = new Material(FindObjectOfType<FriseEditorBehaviour>().lineMaterial);
				lr.positionCount = l.points.Count;
				lr.loop = l.loop;

				lr.useWorldSpace = false;
				lr.widthMultiplier = 0.03f;
				lr.sortingLayerName = "Gizmo-Line";
				var color = UnityEngine.Color.green;
				lr.material.color = color;
				lr.startColor = color;
				lr.endColor = color;

				lr.transform.SetParent(linesGao.transform, false);
				lr.transform.localPosition = Vector3.zero;
				lr.transform.localRotation = Quaternion.identity;
				lr.transform.localScale = Vector3.one;
				lr.transform.gameObject.SetActive(false);
				lines[l.name] = lr;
			}
		}
	}
	public void UpdateLines() {
		if(linesGao != null) linesGao.SetActive(DisplayPolylines);
		if (DisplayPolylines) {
			if((skeleton?.bank?.value?.polylines?.Count ?? 0) > 0) {
				AnimTrackPolyline lastPolyLineList = null;
				if (animTrack?.polylines?.Count > 0) {
					lastPolyLineList = animTrack.polylines.LastOrDefault(p => p.frame <= currentFrame);
				}
				foreach (var l in lines) {
					var lr = l.Value;
					var gao = lr.gameObject;
					if (lastPolyLineList?.entries.Contains(l.Key) ?? false) {
						var color = UnityEngine.Color.green;
						lr.material.color = color;
						lr.startColor = color;
						lr.endColor = color;
						if (gao.activeSelf != true) gao.SetActive(true);
					} else {
						if (DisplayInactivePolylines) {
							var color = UnityEngine.Color.red;
							lr.material.color = color;
							lr.startColor = color;
							lr.endColor = color;
						}
						if (gao.activeSelf != DisplayInactivePolylines) gao.SetActive(DisplayInactivePolylines);
					}
					if (DisplayInactivePolylines || (lastPolyLineList?.entries.Contains(l.Key) ?? false)) {
						var polyline = skeleton?.bank?.value?.polylines.FirstOrDefault(pl => pl.name == l.Key);

						var positions = polyline.points.Select(point => {
							var boneName = point.name;
							var boneIndex = skeleton.GetBoneIndexFromTag2(boneName);
							if (boneIndex != -1) {
								var bone = bones[boneIndex];
								var pos = point.pos.GetUnityVector();
								return transform.InverseTransformPoint(bone.transform.TransformPoint(pos));
							}
							return Vector3.zero;
						});
						lr.SetPositions(positions.ToArray());
						lr.numCornerVertices = 5;
					}
				}
			}
		}
	}

	public void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished && loaded) {
			if (animTrack != null) {
				if (playAnimation) currentFrame += Time.deltaTime * animationSpeed * (Animation?.SubAnim?.playRate ?? 1f);
			} else {
				currentFrame = 0f;
			}
			UpdateAnimation();
		}
	}

	void UpdateAnimation() {
		if(!loaded || skeleton == null || bones == null) return;

		if (animTrack != null) {
			if (animTrack.length == 0) {
				currentFrame = 0;
			} else if (currentFrame >= animTrack.length) {
				currentFrame %= animTrack.length;
			}
			int numBones = Math.Min(animTrack.bonesLists.Count, bones.Length);
			int rootIndex = skeleton.GetBoneIndexFromTag(new StringID("Root"));
			bool useRoot = (alc_tpl?.useRootBone) ?? true;
			bool useRootRotation = Animation?.SubAnim?.useRootRotation ?? true;
			bool defaultFlip = Animation?.SubAnim?.defaultFlip ?? false;
			for (int i = 0; i < numBones; i++) {
				bool isRoot = i == rootIndex;
				/*if (((!alc_tpl?.useRootBone) ?? false) && isRoot) {
					bones[i].localPosition = Vector3.zero;
					bones[i].localScale = Vector3.one;
					bones[i].localRotation = 0f;
				} else {*/
				AnimTrackBonesList bl = animTrack.bonesLists[i];
				if (bl.amountPAS > 0) { // Position Angle Scale
					for (int p = 0; p < bl.amountPAS; p++) {
						AnimTrackBonePAS pas = animTrack.bonePAS[bl.startPAS + p];
						AnimTrackBonePAS next = animTrack.bonePAS[bl.startPAS + ((p + 1) % bl.amountPAS)];
						if (p == bl.amountPAS - 1 || (currentFrame >= pas.frame && currentFrame < next.frame)) {
							Vector2 pos = pas.Position.GetUnityVector();
							Angle rot = pas.Rotation;
							Vector2 scl = pas.Scale.GetUnityVector();
							if (next != pas) {
								float nextFrame = next.frame < pas.frame ? next.frame + animTrack.length : next.frame;
								float lerp = (Mathf.Floor(currentFrame) - pas.frame) / (Mathf.Floor(nextFrame) - pas.frame); // TODO: maybe change to Math.Floor(currentFrame) if animations can't be interpolated. This fixed jittery feet for Rayman
								pos = Vector2.Lerp(pos, next.Position.GetUnityVector(), lerp);
								rot = Mathf.Lerp(rot, next.Rotation, lerp);
								scl = Vector2.Lerp(scl, next.Scale.GetUnityVector(), lerp);
							}
							pos *= animTrack.multiplierP;
							rot *= animTrack.multiplierA;
							scl *= animTrack.multiplierS;

							if (isRoot) {
								if (!useRoot) {
									pos = Vector2.zero;
									scl = Vector2.one;
									if (!useRootRotation) rot = 0f;
								}
								if (defaultFlip) scl = new Vector2(-scl.x, scl.y);
							}

							bones[i].localPosition = pos;
							bones[i].localScale = scl;
							bones[i].localRotation = rot;
							break;
						}
					}
					if (bl.amountZAL > 0) { // Z ALpha
						for (int p = 0; p < bl.amountZAL; p++) {
							AnimTrackBoneZAL zal = animTrack.boneZAL[bl.startZAL + p];
							AnimTrackBoneZAL next = animTrack.boneZAL[bl.startZAL + ((p + 1) % bl.amountZAL)];
							if (p == bl.amountZAL - 1 || (currentFrame >= zal.frame && currentFrame < next.frame)) {
								float z = zal.z;
								float alpha = zal.alpha / 255f;
								if (next != zal) {
									float nextFrame = next.frame < zal.frame ? next.frame + animTrack.length : next.frame;
									float lerp = (currentFrame - zal.frame) / (nextFrame - zal.frame);
									z = Mathf.Lerp(z, next.z, lerp);
									alpha = Mathf.Lerp(alpha, next.alpha / 255f, lerp);
								}
								bones[i].localZ = z;
								bones[i].localAlpha = alpha;
								break;
							}
						}
					}
				}
			}

			// Activate the correct patches
			AnimTrackBML bml = null;
			if (animTrack.bml.Count > 0) {
				// Reset BML at end of animation - except if current BML frame is the first frame
				if (currentBMLFrame > currentFrame && currentBMLFrame != animTrack.bml[0].frame) {
					currentBMLFrame = -1;
				}
				// Find last index that matches current BML
				int currentBMLIndex = currentBMLFrame == -1 ? 0 : (animTrack.bml.ToList().FindLastIndex(b => b.frame == currentBMLFrame) % animTrack.bml.Count);

				for (int i = currentBMLIndex; i < animTrack.bml.Count; i++) {
					AnimTrackBML currentBML = animTrack.bml[i];
					if (currentBML.frame > currentFrame) break;
					//if ((curB.frame > currentFrame) && !(checkHigher && curB.frame > lastBmlFrame)) break;
					bml = currentBML;
				}
			}
			if (bml != null && bml.frame != currentBMLFrame) {
				currentBMLFrame = bml.frame;
				Context l = Controller.MainContext;
				foreach (var pbk in AllPatchBanks) {
					foreach(var p in pbk.Patches) p.Active = false;
				}
				foreach (AnimTrackBML.Entry entry in bml.entries) {
					StringID templateId = entry.templateId;
					var bank = LookupTextureBankId(entry.textureBankId);
					if (bank == null) continue;
					int ind = bank.PBK.templateKeys.GetKeyIndex(templateId);
					if (ind != -1) {
						bank.Patches[ind].Active = true;
						if (l.Settings.EngineVersion == EngineVersion.RO) {
							var texPath = GetTexturePathOrigins(entry.textureBankId);
							if (texPath != null) {
								if (l.Loader.tex.ContainsKey(texPath.stringID)) {
									alc.SetMaterialTextureOrigins((TextureCooked)l.Loader.tex[texPath.stringID], bank.Patches[ind].Renderer);
								}
							}
						}
					}
				}
				foreach (var pbk in AllPatchBanks) {
					foreach (var p in pbk.Patches) {
						if(p?.Object == null) continue;
						p.Object.SetActive(p.Active);
					}
				}
			}


			UpdateLines();

			// Configure Z for all patches
			if (bml == null) {
				bml = animTrack.bml.ToList().FindLast(b => b.frame == currentBMLFrame);
			}
			if (bml != null) {
				ZSortBones();
			}
		} else {
			// Bind pose
			foreach (var b in bones) {
				b.localPosition = Vector3.zero;
				b.localScale = Vector3.one;
				b.localRotation = 0;
			}

			UpdateLines();
			ZSortBones();
		}
	}

	private void ZSortBones() {
		ZListManager zman = Controller.Obj.zListManager;
		foreach (var patchData in AllPatchBanks) {
			for (int i = 0; i < patchData.Patches.Length; i++) {
				if (patchData.Patches[i] == null || patchData.PBK.templates[i].bones.Count == 0) continue;
				var patchRenderer = patchData.Patches[i].Renderer;
				bool patchActive = patchData.Patches[i].Active;
				if (patchActive) {
					//int boneIndex = skeleton.GetBoneIndexFromTag(pbk.templates[i].bones[0].tag);
					int[] boneIndices = patchData.PBK.templates[i].bones.Select(b => skeleton.GetBoneIndexFromTag(b.tag)).ToArray();
					List<float> alphas = new List<float>();
					List<float> zs = new List<float>();
					for (int b = 0; b < boneIndices.Length; b++) {
						if (boneIndices[b] != -1) {
							int boneIndex = boneIndices[b];
							alphas.Add(bones[boneIndex].bindAlpha + bones[boneIndex].localAlpha);
							zs.Add(bones[boneIndex].bindZ + bones[boneIndex].localZ);
						}
					}
					if (alphas.Count > 0) {
						alc.SetColor(new UnityEngine.Color(1f, 1f, 1f, alphas.Average()), patchRenderer);
					}
					if (zs.Count > 0) {
						zman.zDict[patchRenderer] = transform.position.z - zs.Average() / 10000f;
						//patchRenderers[i].transform.localPosition = new Vector3(0,0,zs.Average() / 10000f);
					} else {
						zman.zDict[patchRenderer] = transform.position.z - (i / 10000f);
					}
					/*if (boneIndex != -1) {
						patchMaterials[i].SetColor("_ColorFactor", new UnityEngine.Color(1f, 1f, 1f, bones[boneIndex].bindAlpha + bones[boneIndex].localAlpha));
						//zman.zDict[patchRenderers[i]] = transform.position.z - (i / 10000f);
						zman.zDict[patchRenderers[i]] = transform.position.z - (bones[boneIndex].bindZ + bones[boneIndex].localZ) / 100f;

						if (anims.Count > 0 && anims[animIndex].Item1.filename.Contains("stand_back")) {
							print(i + " - " + pbk.templates[i].bones[0].tag);
						}
					} else {
						zman.zDict[patchRenderers[i]] = transform.position.z - (i / 10000f);
					}*/
				} else {
					if (zman.zDict.ContainsKey(patchRenderer)) {
						zman.zDict.Remove(patchRenderer);
					}
				}
			}
		}
	}

	UnityPatchBank LookupTextureBankId(StringID id) {
		if(patchBanks.ContainsKey(id)) return patchBanks[id];

		// Origins specific
		Context l = Controller.MainContext;
		if (l.Settings.EngineVersion <= EngineVersion.RO) {
			int texInd = animTrack.texturePathKeysOrigins.GetKeyIndex(id);
			if (texInd != -1) {
				pair<StringID, CString> texPath = animTrack.texturePathsOrigins[texInd];
				var key = texPath.Item1;
				if(patchBanksOrigins.ContainsKey(key)) return patchBanksOrigins[key];
			}
		}
		return null;
	}
	Path GetTexturePathOrigins(StringID id) {
		if (patchBanks.ContainsKey(id)) return patchBanks[id].TexturePathOrigins;

		// Origins specific
		int texInd = animTrack.texturePathKeysOrigins.GetKeyIndex(id);
		if (texInd != -1) {
			pair<StringID, CString> texPath = animTrack.texturePathsOrigins[texInd];
			return new Path(texPath.Item2.str);
		}
		return null;
	}
}