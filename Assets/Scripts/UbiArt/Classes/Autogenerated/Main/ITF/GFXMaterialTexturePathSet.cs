using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class GFXMaterialTexturePathSet : CSerializable {
		public Path diffuse;
		public Path normal;
		public Path separateAlpha;
		public Path diffuse_2;
		public Path back_light_2;
		public Path specular;
		public Path colorMask;
		public Path anim_impostor;		
		public Path back_light;
		public Path diffuse_3;
		public Path diffuse_4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				diffuse = s.SerializeObject<Path>(diffuse, name: "diffuse");
				back_light = s.SerializeObject<Path>(back_light, name: "back_light");
				normal = s.SerializeObject<Path>(normal, name: "normal");
				separateAlpha = s.SerializeObject<Path>(separateAlpha, name: "separateAlpha");
				diffuse_2 = s.SerializeObject<Path>(diffuse_2, name: "diffuse_2");
				back_light_2 = s.SerializeObject<Path>(back_light_2, name: "back_light_2");
				anim_impostor = s.SerializeObject<Path>(anim_impostor, name: "anim_impostor");
			} else if(Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				diffuse = s.SerializeObject<Path>(diffuse, name: "diffuse");
				back_light = s.SerializeObject<Path>(back_light, name: "back_light");
				normal = s.SerializeObject<Path>(normal, name: "normal");
				separateAlpha = s.SerializeObject<Path>(separateAlpha, name: "separateAlpha");
				diffuse_2 = s.SerializeObject<Path>(diffuse_2, name: "diffuse_2");
				back_light_2 = s.SerializeObject<Path>(back_light_2, name: "back_light_2");
				anim_impostor = s.SerializeObject<Path>(anim_impostor, name: "anim_impostor");
				diffuse_3 = s.SerializeObject<Path>(diffuse_3, name: "diffuse_3");
				diffuse_4 = s.SerializeObject<Path>(diffuse_4, name: "diffuse_4");
			} else {
				diffuse = s.SerializeObject<Path>(diffuse, name: "diffuse");
				normal = s.SerializeObject<Path>(normal, name: "normal");
				separateAlpha = s.SerializeObject<Path>(separateAlpha, name: "separateAlpha");
				diffuse_2 = s.SerializeObject<Path>(diffuse_2, name: "diffuse_2");
				back_light_2 = s.SerializeObject<Path>(back_light_2, name: "back_light_2");
				specular = s.SerializeObject<Path>(specular, name: "specular");
				colorMask = s.SerializeObject<Path>(colorMask, name: "colorMask");
				anim_impostor = s.SerializeObject<Path>(anim_impostor, name: "anim_impostor");
			}
		}
	}
}

