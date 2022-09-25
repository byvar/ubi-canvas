
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
	//public AnimLightComponent animLightComponent;
	public AnimTrack animTrack;
	public int animIndex = -1;
	public float lastBmlFrame = -1;
	public List<Tuple<Path, AnimTrack>> anims;
	public AnimSkeleton skeleton;
	public UnityBone[] bones;
	public AnimPatchBank pbk;
	public GameObject[] patches;
	public AnimLightComponent alc;
	public SkinnedMeshRenderer[] patchRenderers;
	public bool playAnimation = true;
	public float animationSpeed = 30f;
	public int zValue = 0;
	bool loaded = false;

	//private float updateCounter = 0f;
	public float currentFrame = 0;

	public void Start() {
	}
	public void Init() {
		MapLoader l = MapLoader.Loader;
		if (animIndex > 0 && skeleton != null) {
			currentFrame = 0;
			lastBmlFrame = -1;
			skeleton.ResetBones(bones);
			UpdateAnimation();
		}
		loaded = true;
	}

	public void Update() {
		if (GlobalLoadState.LoadState == GlobalLoadState.State.Finished && loaded && animTrack != null) {
			if(playAnimation) currentFrame += Time.deltaTime * animationSpeed;
			UpdateAnimation();
		}
	}

	void UpdateAnimation() {
		if (loaded && animTrack != null && skeleton != null && bones != null) {
			if (animTrack.length == 0) {
				currentFrame = 0;
			} else if (currentFrame >= animTrack.length) {
				currentFrame %= animTrack.length;
			}
			int numBones = Math.Min(animTrack.bonesLists.Count, bones.Length);
			for (int i = 0; i < numBones; i++) {
				AnimTrackBonesList bl = animTrack.bonesLists[i];
				if (bl.amountPAS > 0) {
					for (int p = 0; p < bl.amountPAS; p++) {
						AnimTrackBonePAS pas = animTrack.bonePAS[bl.startPAS + p];
						AnimTrackBonePAS next = animTrack.bonePAS[bl.startPAS + ((p + 1) % bl.amountPAS)];
						if (p == bl.amountPAS - 1 || (currentFrame >= pas.frame && currentFrame < next.frame)) {
							Vector2 pos = pas.Position;
							Angle rot = pas.Rotation;
							Vector2 scl = pas.Scale;
							if (next != pas) {
								float nextFrame = next.frame < pas.frame ? next.frame + animTrack.length : next.frame;
								float lerp = (currentFrame - pas.frame) / (nextFrame - pas.frame);
								pos = Vector2.Lerp(pos, next.Position, lerp);
								rot = Mathf.Lerp(rot, next.Rotation, lerp);
								scl = Vector2.Lerp(scl, next.Scale, lerp);
							}
							pos *= animTrack.multiplierP;
							rot *= animTrack.multiplierA;
							scl *= animTrack.multiplierS;
							bones[i].localPosition = pos;
							bones[i].localScale = scl;
							bones[i].localRotation = rot;
							break;
						}
					}
				}
				if (bl.amountZAL > 0) {
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

			// Activate the correct patches
			AnimTrackBML bml = null;
			bool checkHigher = false;
			if (animTrack.bml.Count > 0) {
				int index = lastBmlFrame == -1 ? 0 : (animTrack.bml.ToList().FindLastIndex(b => b.frame == lastBmlFrame) + 1) % animTrack.bml.Count;
				if (lastBmlFrame > currentFrame) {
					checkHigher = true;
				}
				for (int i = 0; i < animTrack.bml.Count; i++) {
					AnimTrackBML curB = animTrack.bml[(i + index) % animTrack.bml.Count];
					if ((curB.frame > currentFrame) && !(checkHigher && curB.frame > lastBmlFrame)) break;
					bml = curB;
				}
			}
			if(bml != null && bml.frame != lastBmlFrame) {
				lastBmlFrame = bml.frame;
				List<int> indexes = new List<int>();
				MapLoader l = MapLoader.Loader;
				foreach (AnimTrackBML.Entry entry in bml.entries) {
					StringID templateId = entry.templateId;
					int ind = pbk.templateKeys.GetKeyIndex(templateId);
					if (ind != -1) {
						indexes.Add(ind);
						if (l.Settings.engineVersion == Settings.EngineVersion.RO) {
							int texInd = animTrack.texturePathKeysOrigins.GetKeyIndex(entry.textureBankId);
							if (texInd != -1) {
								Pair<StringID, CString> texPath = animTrack.texturePathsOrigins[texInd];
								if (l.tex.ContainsKey(texPath.Item1)) {
									alc.SetMaterialTextureOrigins(l.tex[texPath.Item1], patchRenderers[ind]);
								}
							}
						}
					}
				}
				for(int i = 0; i < patches.Length; i++) {
					if (patches[i] != null) {
						patches[i].SetActive(indexes.Contains(i));
					}
				}
			}


			// Configure Z for all patches
			ZListManager zman = Controller.Obj.zListManager;
			if (bml == null) {
				bml = animTrack.bml.ToList().FindLast(b => b.frame == lastBmlFrame);
			}
			if (bml != null) {
				List<int> indexes = new List<int>();
				foreach (AnimTrackBML.Entry entry in bml.entries) {
					StringID templateId = entry.templateId;
					int ind = pbk.templateKeys.GetKeyIndex(templateId);
					if (ind != -1) {
						indexes.Add(ind);
					}
				}
				for (int i = 0; i < patches.Length; i++) {
					if (patches[i] == null || pbk.templates[i].bones.Count == 0) continue;
					bool patchActive = indexes.Contains(i);
					if (patchActive) {
						//int boneIndex = skeleton.GetBoneIndexFromTag(pbk.templates[i].bones[0].tag);
						int[] boneIndices = pbk.templates[i].bones.Select(b => skeleton.GetBoneIndexFromTag(b.tag)).ToArray();
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
							alc.SetColor(new UnityEngine.Color(1f, 1f, 1f, alphas.Average()), patchRenderers[i]);
						}
						if (zs.Count > 0) {
							zman.zDict[patchRenderers[i]] = transform.position.z - zs.Average() / 10000f;
							//patchRenderers[i].transform.localPosition = new Vector3(0,0,zs.Average() / 10000f);
						} else {
							zman.zDict[patchRenderers[i]] = transform.position.z - (i / 10000f);
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
						if (zman.zDict.ContainsKey(patchRenderers[i])) {
							zman.zDict.Remove(patchRenderers[i]);
						}
					}
				}
			}
		}
	}

	/*private void SortPatchZ(List<int> indexes) {
		Dictionary<int, float> patchZ = new Dictionary<int, float>();
		for (int i = 0; i < patches.Length; i++) {
			if (patches[i] == null || pbk.templates[i].bones.Count == 0) continue;
			bool patchActive = indexes.Contains(i);
			if (patchActive) {
				int boneIndex = skeleton.GetBoneIndexFromTag(pbk.templates[i].bones[0].tag);
				if (boneIndex != -1) {
					patchMaterials[i].SetColor("_ColorFactor", new UnityEngine.Color(1f, 1f, 1f, bones[boneIndex].bindAlpha + bones[boneIndex].localAlpha));
					//zman.zDict[patchRenderers[i]] = transform.position.z - (i / 10000f);
					zman.zDict[patchRenderers[i]] = transform.position.z - (bones[boneIndex].bindZ + bones[boneIndex].localZ) / 100f;
				} else {
					zman.zDict[patchRenderers[i]] = transform.position.z - (i / 10000f);
				}
			} else {
				if (zman.zDict.ContainsKey(patchRenderers[i])) {
					zman.zDict.Remove(patchRenderers[i]);
				}
			}
		}
		List<KeyValuePair<int, float>> list = patchZ.ToList();
		list.Sort((k1, k2) => k2.Value.CompareTo(k1.Value));
	}*/

}