using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_LeaderboardComponent_Template : CSerializable {
		public int int__0;
		public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
		}
		public override uint? ClassCRC => 0x2B458C21;
	}
}

