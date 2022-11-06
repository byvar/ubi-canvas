using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerCostumePriceComponent_Template : CSerializable {
		public Vec2d offset;
		public StringID bone;
		public Path electoonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			bone = s.SerializeObject<StringID>(bone, name: "bone");
			electoonPath = s.SerializeObject<Path>(electoonPath, name: "electoonPath");
		}
		public override uint? ClassCRC => 0xC8D513A6;
	}
}

