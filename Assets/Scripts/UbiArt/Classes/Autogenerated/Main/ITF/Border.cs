using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Border : CSerializable {
		[Serialize("TextureRatio"         )] public float TextureRatio;
		[Serialize("BorderHeight"         )] public float BorderHeight;
		[Serialize("BorderVisualOffset"   )] public float BorderVisualOffset;
		[Serialize("BorderBig_TileCount"  )] public float BorderBig_TileCount;
		[Serialize("BorderSmall_TileCount")] public float BorderSmall_TileCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TextureRatio));
			SerializeField(s, nameof(BorderHeight));
			SerializeField(s, nameof(BorderVisualOffset));
			SerializeField(s, nameof(BorderBig_TileCount));
			SerializeField(s, nameof(BorderSmall_TileCount));
		}
	}
}

