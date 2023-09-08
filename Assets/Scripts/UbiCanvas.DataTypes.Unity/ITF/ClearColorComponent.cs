using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class ClearColorComponent {
		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			var context = UbiArtContext;
			ShaderManager shaderManager = GameObject.FindObjectOfType<ShaderManager>();
			if (shaderManager != null) {
				if (clearColor != null && clearColor.Enable) {
					Camera.main.backgroundColor = (clearColor.ClearColor ?? Color.Black).GetUnityColor();
					shaderManager.frontLightCamera.backgroundColor = (clearColor.ClearFrontLightColor ?? Color.Black).GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = (clearColor.ClearBackLightColor ?? Color.Black).GetUnityColor();
				} else if (context.Settings.Game == Game.RL || context.Settings.Game == Game.COL) {
					Camera.main.backgroundColor = (clearColor2 ?? Color.Black).GetUnityColor();
					shaderManager.frontLightCamera.backgroundColor = (clearFrontLightColor ?? Color.Black).GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = (clearBackLightColor ?? Color.Black).GetUnityColor();
				}
			}
		}
	}
}
