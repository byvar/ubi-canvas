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
					Camera.main.backgroundColor = clearColor.ClearColor.GetUnityColor();
					shaderManager.frontLightCamera.backgroundColor = clearColor.ClearFrontLightColor.GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = clearColor.ClearBackLightColor.GetUnityColor();
				} else if (context.Settings.game == Settings.Game.RL || context.Settings.game == Settings.Game.COL) {
					Camera.main.backgroundColor = clearColor2.GetUnityColor();
					shaderManager.frontLightCamera.backgroundColor = clearFrontLightColor.GetUnityColor();
					shaderManager.backLightCamera.backgroundColor = clearBackLightColor.GetUnityColor();
				}
			}
		}
	}
}
