using System;
using System.Collections;
using System.Collections.Generic;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class ShaderManager : MonoBehaviour {
	public RenderTexture frontLight;
	public RenderTexture backLight;
	public Camera frontLightCamera;
	public Camera backLightCamera;
	private float lastAspectRatio = 0f;
	public bool enableLighting = true; //private bool _enableLighting = true;

	// Use this for initialization
	void Start() {
		UpdateRenderTextures();
		Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
	}

	void UpdateRenderTextures() {
		if(!enableLighting) return;
		int newW = Screen.width;
		int newH = Screen.height;
		float aspect = newW / (float)newH;
		if (aspect != lastAspectRatio) {
			if (frontLight != null) frontLight.Release();
			if (backLight != null) backLight.Release();
			frontLight = new RenderTexture(Mathf.CeilToInt(aspect * 64), 64, 24);
			backLight = new RenderTexture(Mathf.CeilToInt(aspect * 64), 64, 24);
			frontLightCamera.targetTexture = frontLight;
			backLightCamera.targetTexture = backLight;

			Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
			Shader.SetGlobalTexture("_LightsBackLight", backLight);
		}
	}

    // Update is called once per frame
    void Update() {
		if (UnityEngine.Input.GetKeyDown(KeyCode.L)) {
			enableLighting = !enableLighting;
			Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
		}
		UpdateRenderTextures();

		frontLightCamera.transparencySortMode = TransparencySortMode.CustomAxis;
		frontLightCamera.transparencySortAxis = new Vector3(0.0f, 0.0f, 1.0f);
		backLightCamera.transparencySortMode = TransparencySortMode.CustomAxis;
		backLightCamera.transparencySortAxis = new Vector3(0.0f, 0.0f, 1.0f);
		/*Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
		Shader.SetGlobalTexture("_LightsBackLight", backLight);*/
	}


}
