using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RuneProfileConfig_Template : CSerializable {
		public uint runeBagSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			runeBagSize = s.Serialize<uint>(runeBagSize, name: "runeBagSize");
		}
		public override uint? ClassCRC => 0x2492BB40;
	}
}

