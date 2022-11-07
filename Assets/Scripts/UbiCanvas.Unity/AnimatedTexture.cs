
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour {
	public FriseTextureConfig config;
	public Renderer ren;
	public int index;
	public float animationSpeed = 1f;
	private float time = 0f;
	private float animationResetTime = 0f;
	private Vector2 offset = Vector2.zero;
	MaterialPropertyBlock mpb;

	//public float animationSpeed = 15f; // Force 60fps w/ frameskip
	/*private float updateCounter = 0f;
	public uint currentFrame = 0;

	public void Start() {
	}

	public void Update() {
		if (config != null) {
			updateCounter += Time.deltaTime * animationSpeed;
			while (updateCounter >= 1f) {
				updateCounter -= 1f;
				currentFrame++;
				if (updateCounter < 1f) UpdateFrame();
			}
		}
	}

	void UpdateFrame() {
		if (config != null) {
			if (config.scrollUV != Vector2.zero) {
				float offsetU = currentFrame * -config.scrollUV.x;
				float offsetV = currentFrame * config.scrollUV.y;
				mat.SetTextureOffset("_Diffuse", new Vector2(offsetU, offsetV));
				mat.SetTextureOffset("_BackLight", new Vector2(offsetU, offsetV));
			}
		}
	}*/


	public void ResetMaterial(FriseTextureConfig config, Renderer ren, int index = 0) {
		if(mpb == null) mpb = new MaterialPropertyBlock();
		this.config = config;
		this.ren = ren;
		this.index = index;
		time = 0f;
		animationResetTime = 1f;
		if (config.scrollUV.x != 0) {
			animationResetTime /= Mathf.Abs(config.scrollUV.x);
		}
		if (config.scrollUV.y != 0) {
			animationResetTime /= Mathf.Abs(config.scrollUV.y);
		}
		/*currentFrame = 0;
		updateCounter = 0;*/
	}

	public void Update() {
		if (GlobalLoadState.LoadState != GlobalLoadState.State.Finished) return;
		if (config != null && ren != null && mpb != null) {
			if (config.scrollUV.GetUnityVector() != Vector2.zero) {
				time += Time.deltaTime * animationSpeed;
				if (time > animationResetTime) {
					time = time % animationResetTime;
				}
				offset = new Vector2(time * -config.scrollUV.x, time * config.scrollUV.y);
				Vector4 v = new Vector4(1,1,offset.x, offset.y);
				ren.GetPropertyBlock(mpb, index);
				mpb.SetVector("_Diffuse_ST", v);
				mpb.SetVector("_BackLight_ST", v);
				ren.SetPropertyBlock(mpb, index);
			}
			/*updateCounter += Time.deltaTime * animationSpeed;
			while (updateCounter >= 1f) {
				updateCounter -= 1f;
				currentFrame++;
				if (updateCounter < 1f) UpdateFrame();
			}*/
		}
	}

}