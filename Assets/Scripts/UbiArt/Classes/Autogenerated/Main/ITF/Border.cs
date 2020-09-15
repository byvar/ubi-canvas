using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Border : CSerializable {
		public float TextureRatio;
		public float BorderHeight;
		public float BorderVisualOffset;
		public float BorderBig_TileCount;
		public float BorderSmall_TileCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TextureRatio = s.Serialize<float>(TextureRatio, name: "TextureRatio");
			BorderHeight = s.Serialize<float>(BorderHeight, name: "BorderHeight");
			BorderVisualOffset = s.Serialize<float>(BorderVisualOffset, name: "BorderVisualOffset");
			BorderBig_TileCount = s.Serialize<float>(BorderBig_TileCount, name: "BorderBig_TileCount");
			BorderSmall_TileCount = s.Serialize<float>(BorderSmall_TileCount, name: "BorderSmall_TileCount");
		}
	}
}

