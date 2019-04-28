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
					Camera.main.backgroundColor = ClearColor.ClearColor;
					shaderManager.frontLightCamera.backgroundColor = ClearColor.ClearFrontLightColor;
					shaderManager.backLightCamera.backgroundColor = ClearColor.ClearBackLightColor;
				}
				if (Lighting != null && Lighting.Enable) {
					shaderManager.frontLightCamera.backgroundColor = Lighting.GlobalColor;
					shaderManager.backLightCamera.backgroundColor = Lighting.GlobalColor;
				}
			}
		}
	}
}
