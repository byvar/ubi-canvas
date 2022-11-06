using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class RJR_PowerUp : CSerializable {
		public int int__0;
		public int int__1;
		public int int__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
			int__1 = s.Serialize<int>(int__1, name: "int__1");
			int__2 = s.Serialize<int>(int__2, name: "int__2");
		}
	}
}

