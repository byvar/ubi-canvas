using System;
using System.Collections;
using System.Collections.Generic;
using UbiArt.ITF;
using UnityEngine;
using UnityEngine.UI;

public class ShaderManager : MonoBehaviour {
	private RenderTexture frontLight;
	private RenderTexture backLight;
	public Camera frontLightCamera;
	public Camera backLightCamera;
	private float lastAspectRatio = 0f;
	public bool enableLighting = true; //private bool _enableLighting = true;

	// Use this for initialization
	void Start() {
		UpdateRenderTextures();
		Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
	}

	private void OnDestroy() {
		enableLighting = false;
		if (frontLight != null) frontLight.Release();
		if(backLight != null) backLight.Release();
	}

	void UpdateRenderTextures() {
		if(!enableLighting) return;
		int newW = Screen.width;
		int newH = Screen.height;
		float aspect = newW / (float)newH;
		if (aspect != lastAspectRatio) {
			int rth = 64;
			int rtw = Mathf.CeilToInt(aspect * rth);
			if (frontLight != null) {
				frontLight.Release();
				frontLight.width = rtw;
			} else {
				frontLight = new RenderTexture(rtw, rth, 24);
				frontLightCamera.targetTexture = frontLight;
				Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
			}
			if (backLight != null) {
				backLight.Release();
				backLight.width = rtw;
			} else {
				backLight = new RenderTexture(rtw, rth, 24);
				backLightCamera.targetTexture = backLight;
				Shader.SetGlobalTexture("_LightsBackLight", backLight);
			}
			lastAspectRatio = aspect;
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
