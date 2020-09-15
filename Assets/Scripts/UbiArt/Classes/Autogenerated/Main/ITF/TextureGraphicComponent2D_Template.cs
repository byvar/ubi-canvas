using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class TextureGraphicComponent2D_Template : GraphicComponent_Template {
		public Path texture;
		public uint rank;
		public CArray<TexLanguageOverride> texOverrides;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				rank = s.Serialize<uint>(rank, name: "rank");
				texOverrides = s.SerializeObject<CArray<TexLanguageOverride>>(texOverrides, name: "texOverrides");
			} else {
				texture = s.SerializeObject<Path>(texture, name: "texture");
				rank = s.Serialize<uint>(rank, name: "rank");
			}
		}
		public override uint? ClassCRC => 0xA2ACC46E;

		[Games(GameFlags.RO)]
		public partial class TexLanguageOverride : CSerializable {
			public int language;
			public Path texture;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				language = s.Serialize<int>(language, name: "language");
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
		}
	}
}

