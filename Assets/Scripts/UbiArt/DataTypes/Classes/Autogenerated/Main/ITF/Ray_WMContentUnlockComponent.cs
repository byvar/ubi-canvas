using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WMContentUnlockComponent : CSerializable {
		public Vec2d RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				RELATIVEPOS = s.SerializeObject<Vec2d>(RELATIVEPOS, name: "RELATIVEPOS");
			}
		}
		public override uint? ClassCRC => 0x2701D106;
	}
}

