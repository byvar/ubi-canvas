using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class TextureGraphicComponent2D_Template : GraphicComponent_Template {
		[Serialize("texture"     )] public Path texture;
		[Serialize("rank"        )] public uint rank;
		[Serialize("texOverrides")] public CArray<TexLanguageOverride> texOverrides;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(rank));
				SerializeField(s, nameof(texOverrides));
			} else {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(rank));
			}
		}
		public override uint? ClassCRC => 0xA2ACC46E;

		[Games(GameFlags.RO)]
		public partial class TexLanguageOverride : CSerializable {
			[Serialize("language")] public int language;
			[Serialize("texture")] public Path texture;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(language));
				SerializeField(s, nameof(texture));
			}
		}
	}
}

