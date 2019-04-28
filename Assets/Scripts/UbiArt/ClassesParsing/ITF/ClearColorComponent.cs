using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class ClearColorComponent {
		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			ShaderManager shaderManager = GameObject.FindObjectOfType<ShaderManager>();
			if (shaderManager != null) {
				if (clearColor != null && clearColor.Enable) {
					Camera.main.backgroundColor = clearColor.ClearColor;
					shaderManager.frontLightCamera.backgroundColor = clearColor.ClearFrontLightColor;
					shaderManager.backLightCamera.backgroundColor = clearColor.ClearBackLightColor;
				} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
					Camera.main.backgroundColor = clearColor2;
					shaderManager.frontLightCamera.backgroundColor = clearFrontLightColor;
					shaderManager.backLightCamera.backgroundColor = clearBackLightColor;
				}
			}
		}
	}
}
