using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_RFR_LevelComponent_Template : CSerializable {
		public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
		}
		public override uint? ClassCRC => 0x9D724B90;
	}
}

