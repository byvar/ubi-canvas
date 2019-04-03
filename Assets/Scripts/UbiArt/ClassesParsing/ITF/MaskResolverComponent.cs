using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class MaskResolverComponent {
		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is MaskResolverComponent_Template) {
				MaskResolverComponent_Template tpl = template as MaskResolverComponent_Template;
				ShaderManager shaderManager = GameObject.FindObjectOfType<ShaderManager>();
				if (shaderManager != null) {
					if (tpl.resolveFrontLightBuffer) {
						//shaderManager.frontLightCamera.clearFlags = clearFrontLightBuffer ? CameraClearFlags.SolidColor : CameraClearFlags.Nothing;
						shaderManager.frontLightCamera.backgroundColor = clearFrontLightColor;
					}
					if (tpl.resolveBackLightBuffer) {
						//shaderManager.backLightCamera.clearFlags = clearBackLightBuffer ? CameraClearFlags.SolidColor : CameraClearFlags.Nothing;
						shaderManager.backLightCamera.backgroundColor = clearBackLightColor;
					}
				}
			}
		}
	}
}
