using UbiArt.Animation;
using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimLightComponent {
		public GenericFile<GFXMaterialShader_Template> shader;

		public override void InitUnityComponent(Actor act, GameObject gao, ActorComponent_Template template, int index) {
			base.InitUnityComponent(act, gao, template, index);
			if (template != null && template is AnimLightComponent_Template) {
				AnimLightComponent_Template tpl = template as AnimLightComponent_Template;
				
			}
		}

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (isFirstLoad) {
				MapLoader l = MapLoader.Loader;
				l.Load(MatShader, (extS) => {
					if (l.msh.ContainsKey(MatShader.stringID)) {
						shader = l.msh[MatShader.stringID];
					} else {
						extS.Serialize(ref shader);
						l.msh[MatShader.stringID] = shader;
					}
				});
			}
		}
	}
}
