
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UbiArt.ITF;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour {
	public FriseTextureConfig config;
	public Material mat;
	public float animationSpeed = 15f; // Force 60fps w/ frameskip
	private float updateCounter = 0f;
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

	public void ResetMaterial(FriseTextureConfig config, Material mat) {
		this.config = config;
		this.mat = mat;
		currentFrame = 0;
		updateCounter = 0;
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
	}
}