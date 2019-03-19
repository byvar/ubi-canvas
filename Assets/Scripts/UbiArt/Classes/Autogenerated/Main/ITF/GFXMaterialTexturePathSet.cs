using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class GFXMaterialTexturePathSet : CSerializable {
		[Serialize("diffuse"      )] public Path diffuse;
		[Serialize("normal"       )] public Path normal;
		[Serialize("separateAlpha")] public Path separateAlpha;
		[Serialize("diffuse_2"    )] public Path diffuse_2;
		[Serialize("back_light_2" )] public Path back_light_2;
		[Serialize("specular"     )] public Path specular;
		[Serialize("colorMask"    )] public Path colorMask;
		[Serialize("anim_impostor")] public Path anim_impostor;
		[Serialize("Path__0"      )] public Path Path__0;
		[Serialize("Path__1"      )] public Path Path__1;
		[Serialize("Path__2"      )] public Path Path__2;
		[Serialize("Path__3"      )] public Path Path__3;
		[Serialize("Path__4"      )] public Path Path__4;
		[Serialize("Path__5"      )] public Path Path__5;
		[Serialize("Path__6"      )] public Path Path__6;
		[Serialize("Path__7"      )] public Path Path__7;
		[Serialize("Path__8"      )] public Path Path__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Path__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(Path__4));
				SerializeField(s, nameof(Path__5));
				SerializeField(s, nameof(Path__6));
				SerializeField(s, nameof(Path__7));
				SerializeField(s, nameof(Path__8));
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

