
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt.ITF;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour {
	public FriseTextureConfig config;
	public Material mat;
	public float animationSpeed = 1f;
	private float time = 0f;
	private float animationResetTime = 0f;
	private Vector2 offset = Vector2.zero;

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


	public void ResetMaterial(FriseTextureConfig config, Material mat) {
		this.config = config;
		this.mat = mat;
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
		if (config != null) {
			if (config.scrollUV != Vector2.zero) {
				time += Time.deltaTime * animationSpeed;
				if (time > animationResetTime) {
					time = time % animationResetTime;
				}
				offset = new Vector2(time * -config.scrollUV.x, time * config.scrollUV.y);
				mat.SetTextureOffset("_Diffuse", offset);
				mat.SetTextureOffset("_BackLight", offset);
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