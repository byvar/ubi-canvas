
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
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
	public Material[] patchMaterials;
	public bool playAnimation = true;
	public float animationSpeed = 30f;
	public int zValue = 0;
	bool loaded = false;

	private float updateCounter = 0f;
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
		if (loaded && animTrack != null) {
			currentFrame += Time.deltaTime * animationSpeed;
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

			for (int i = 0; i < animTrack.bonesLists.Count; i++) {
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
							//bones[i].alpha = alpha;
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
				foreach (AnimTrackBML.Entry entry in bml.entries) {
					StringID templateId = entry.templateId;
					int ind = pbk.templateKeys.GetKeyIndex(templateId);
					if (ind != -1) {
						indexes.Add(ind);
					}
				}
				for(int i = 0; i < patches.Length; i++) {
					if (patches[i] != null) {
						patches[i].SetActive(indexes.Contains(i));
					}
				}
			}


			// Configure Z for all patches
			ZListManager zman = MapLoader.Loader.controller.zListManager;
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
						int boneIndex = skeleton.GetBoneIndexFromTag(pbk.templates[i].bones[0].tag);
						zman.zDict[patchMaterials[i]] = transform.position.z - bones[boneIndex].bindZ - bones[boneIndex].localZ;
					} else {
						if (zman.zDict.ContainsKey(patchMaterials[i])) {
							zman.zDict.Remove(patchMaterials[i]);
						}
					}
				}
			}
		}
	}
}