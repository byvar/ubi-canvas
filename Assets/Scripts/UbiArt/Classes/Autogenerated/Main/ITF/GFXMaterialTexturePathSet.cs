using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class GFXMaterialTexturePathSet : CSerializable {
		[Serialize("diffuse"      )] public Path diffuse;
		[Serialize("normal"       )] public Path normal;
		[Serialize("separateAlpha")] public Path separateAlpha;
		[Serialize("diffuse_2"    )] public Path diffuse_2;
		[Serialize("back_light_2" )] public Path back_light_2;
		[Serialize("specular"     )] public Path specular;
		[Serialize("colorMask"    )] public Path colorMask;
		[Serialize("anim_impostor")] public Path anim_impostor;		
		[Serialize("back_light"   )] public Path back_light;
		[Serialize("diffuse_3"    )] public Path diffuse_3;
		[Serialize("diffuse_4"    )] public Path diffuse_4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(diffuse));
				SerializeField(s, nameof(back_light));
				SerializeField(s, nameof(normal));
				SerializeField(s, nameof(separateAlpha));
				SerializeField(s, nameof(diffuse_2));
				SerializeField(s, nameof(back_light_2));
				SerializeField(s, nameof(anim_impostor));
			} else if(Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(diffuse));
				SerializeField(s, nameof(back_light));
				SerializeField(s, nameof(normal));
				SerializeField(s, nameof(separateAlpha));
				SerializeField(s, nameof(diffuse_2));
				SerializeField(s, nameof(back_light_2));
				SerializeField(s, nameof(anim_impostor));
				SerializeField(s, nameof(diffuse_3));
				SerializeField(s, nameof(diffuse_4));
			} else {
				SerializeField(s, nameof(diffuse));
				SerializeField(s, nameof(normal));
				SerializeField(s, nameof(separateAlpha));
				SerializeField(s, nameof(diffuse_2));
				SerializeField(s, nameof(back_light_2));
				SerializeField(s, nameof(specular));
				SerializeField(s, nameof(colorMask));
				SerializeField(s, nameof(anim_impostor));
			}
		}
	}
}

