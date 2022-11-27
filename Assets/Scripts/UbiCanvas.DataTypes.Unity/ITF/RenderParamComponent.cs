using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderParamComponent {
		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			ShaderManager shaderManager = GameObject.FindObjectOfType<ShaderManager>();
			if (shaderManager != null) {
				if (ClearColor != null && ClearColor.Enable) {
					Camera.main.backgroundColor = (ClearColor.ClearColor ?? Color.Black).GetUnityColor();
					shaderManager.frontLightCamera.backgroundColor = (ClearColor.ClearFrontLightColor ?? Color.Black).GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = (ClearColor.ClearBackLightColor ?? Color.Black).GetUnityColor();
				}
				if (Lighting != null && Lighting.Enable) {
					shaderManager.frontLightCamera.backgroundColor = (Lighting.GlobalColor ?? Color.Black).GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = (Lighting.GlobalColor ?? Color.Black).GetUnityColor();
				}
			}
		}
	}
}
