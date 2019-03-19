using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_17_sub_71E3B0 : CSerializable {
		[Serialize("networkDT"             )] public uint networkDT;
		[Serialize("networkUpdateSleepTime")] public uint networkUpdateSleepTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(networkDT));
			SerializeField(s, nameof(networkUpdateSleepTime));
		}
		public override uint? ClassCRC => 0xA26D279A;
	}
}

