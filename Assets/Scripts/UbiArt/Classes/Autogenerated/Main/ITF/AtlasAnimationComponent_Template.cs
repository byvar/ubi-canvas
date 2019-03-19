using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class AtlasAnimationComponent_Template : GraphicComponent_Template {
		[Serialize("texture" )] public Path texture;
		[Serialize("material")] public GFXMaterialSerializable material;
		[Serialize("playRate")] public float playRate;
		[Serialize("width"   )] public float width;
		[Serialize("height"  )] public float height;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
			}
		}
		public override uint? ClassCRC => 0x90B7EDA3;
	}
}

