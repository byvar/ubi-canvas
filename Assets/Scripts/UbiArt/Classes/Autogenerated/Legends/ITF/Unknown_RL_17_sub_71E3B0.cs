using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_17_sub_71E3B0 : CSerializable {
		public uint networkDT;
		public uint networkUpdateSleepTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			networkDT = s.Serialize<uint>(networkDT, name: "networkDT");
			networkUpdateSleepTime = s.Serialize<uint>(networkUpdateSleepTime, name: "networkUpdateSleepTime");
		}
		public override uint? ClassCRC => 0xA26D279A;
	}
}

