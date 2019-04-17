
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
	public List<GameObject> patches;
	public bool playAnimation = true;
	public float animationSpeed = 30f;
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
			int bmlCount = animTrack.bml.Count;
			if (bmlCount > 0) {
				int bmlIndex = 0;
				while (bmlCount > bmlIndex+1 && currentFrame >= animTrack.bml[bmlIndex+1].frame) {
					bmlIndex++;
				}
				// Do bml patch & texturebank switcheroo here
			}
			for (int i = 0; i < animTrack.bonesLists.Count; i++) {
				AnimTrackBonesList bl = animTrack.bonesLists[i];
				if (bl.amountPAS > 0) {
					for (int p = 0; p < bl.amountPAS; p++) {
						AnimTrackBonePAS pas = animTrack.bonePAS[bl.startPAS + p];
						AnimTrackBonePAS next = animTrack.bonePAS[bl.startPAS + ((p + 1) % bl.amountPAS)];
						if (p == bl.amountPAS - 1 || currentFrame < next.frame) {
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
			}
			AnimTrackBML bml = null;
			float currentBmlDifFrame = currentFrame;
			if (currentFrame < lastBmlFrame) {
				currentBmlDifFrame += animTrack.length;
			}
			for (int i = 0; i < animTrack.bml.Count; i++) {
				if (animTrack.bml[i].frame <= currentBmlDifFrame) {
					bml = animTrack.bml[i];
				}
			}
			if(bml != null && bml.frame != lastBmlFrame) {
				lastBmlFrame = bml.frame;
				CArray<StringID> keys = pbk.templateKeys.keysLegends;
				List<int> indexes = new List<int>();
				foreach (AnimTrackBML.Entry entry in bml.entries) {
					StringID templateId = entry.templateId;
					int ind = keys.IndexOf(templateId);
					if (ind != -1) {
						indexes.Add(ind);
					}
				}
				for(int i = 0; i < patches.Count; i++) {
					patches[i].SetActive(indexes.Contains(i));
				}
			}
		}
	}
}