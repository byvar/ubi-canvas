using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionComponent : CSerializable {
		public int listenToTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			listenToTrigger = s.Serialize<int>(listenToTrigger, name: "listenToTrigger");
		}
		public override uint? ClassCRC => 0x06308FAF;
	}
}

