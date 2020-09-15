using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DrawCameraComponent_Template : CSerializable {
		public Angle focale;
		public float depth;
		public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			focale = s.SerializeObject<Angle>(focale, name: "focale");
			depth = s.Serialize<float>(depth, name: "depth");
			offset = s.SerializeObject<Vec3d>(offset, name: "offset");
		}
		public override uint? ClassCRC => 0x7E65B07D;
	}
}

