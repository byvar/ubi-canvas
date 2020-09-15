using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_18_sub_72DD90 : CSerializable {
		public int enabled;
		public float capsuleJumpLimit;
		public float minFluidDepth;
		public Placeholder instance0;
		public Placeholder instance1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enabled = s.Serialize<int>(enabled, name: "enabled");
			capsuleJumpLimit = s.Serialize<float>(capsuleJumpLimit, name: "capsuleJumpLimit");
			minFluidDepth = s.Serialize<float>(minFluidDepth, name: "minFluidDepth");
			instance0 = s.SerializeObject<Placeholder>(instance0, name: "instance0");
			instance1 = s.SerializeObject<Placeholder>(instance1, name: "instance1");
		}
		public override uint? ClassCRC => 0xFC4FF4C5;
	}
}

