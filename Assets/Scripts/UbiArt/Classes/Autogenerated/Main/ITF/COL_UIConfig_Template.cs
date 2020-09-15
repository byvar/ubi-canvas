using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIConfig_Template : CSerializable {
		public int isDLCData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isDLCData = s.Serialize<int>(isDLCData, name: "isDLCData");
		}
		public override uint? ClassCRC => 0x287853D1;
	}
}

