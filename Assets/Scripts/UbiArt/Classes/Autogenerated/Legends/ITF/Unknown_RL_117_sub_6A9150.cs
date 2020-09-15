using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_117_sub_6A9150 : CSerializable {
		public int active;
		public Vec3d offset;
		public int applyAlways;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			active = s.Serialize<int>(active, name: "active");
			offset = s.SerializeObject<Vec3d>(offset, name: "offset");
			applyAlways = s.Serialize<int>(applyAlways, name: "applyAlways");
		}
		public override uint? ClassCRC => 0xA8C26DDA;
	}
}

