using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionSetProgress_Template : CSerializable {
		public float progress;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			progress = s.Serialize<float>(progress, name: "progress");
		}
		public override uint? ClassCRC => 0x463F3ADB;
	}
}

