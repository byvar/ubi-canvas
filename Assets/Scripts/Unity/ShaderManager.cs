using System.Collections;
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
		if (Input.GetKeyDown(KeyCode.L)) {
			enableLighting = !enableLighting;
			Shader.SetGlobalFloat("_EnableLighting", enableLighting ? 1f : 0f);
		}
		/*Shader.SetGlobalTexture("_LightsFrontLight", frontLight);
		Shader.SetGlobalTexture("_LightsBackLight", backLight);*/
	}
}
