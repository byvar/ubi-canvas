
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
	public List<Tuple<Path, AnimTrack>> anims;
	public AnimSkeleton skeleton;
	public UnityBone[] bones;
	public bool playAnimation = true;
	public float animationSpeed = 30f;
	bool loaded = false;

	private float updateCounter = 0f;
	public float currentFrame = 0;

	public void Start() {
	}
	public void Init() {
		MapLoader l = MapLoader.Loader;
		if (animTrack != null && skeleton != null) {
			currentFrame = 0;
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
						AnimBonePAS pas = animTrack.bonePAS[bl.startPAS + p];
						AnimBonePAS next = animTrack.bonePAS[bl.startPAS + ((p + 1) % bl.amountPAS)];
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
							pos *= animTrack.flt0;
							rot *= animTrack.flt1;
							scl *= animTrack.flt2;
							bones[i].localPosition = pos;
							bones[i].localScale = scl;
							bones[i].localRotation = rot;
							break;
						}
					}
				}
			}
		}
	}
}