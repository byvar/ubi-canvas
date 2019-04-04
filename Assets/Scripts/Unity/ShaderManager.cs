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
	public bool enableLighting = true; private bool _enableLighting = true;

	// Use this for initialization
	void Start() {
		Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
		Shader.SetGlobalTexture("_LightsBackLight", backLight);
		Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
	}

    // Update is called once per frame
    void Update() {
		if (UnityEngine.Input.GetKeyDown(KeyCode.L)) {
			enableLighting = !enableLighting;
			Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
		}
		frontLightCamera.transparencySortMode = TransparencySortMode.CustomAxis;
		frontLightCamera.transparencySortAxis = new Vector3(0.0f, 0.0f, 1.0f);
		backLightCamera.transparencySortMode = TransparencySortMode.CustomAxis;
		backLightCamera.transparencySortAxis = new Vector3(0.0f, 0.0f, 1.0f);
		/*Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
		Shader.SetGlobalTexture("_LightsBackLight", backLight);*/
	}


}
