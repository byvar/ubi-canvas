using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventLumReachesScore : Event {
		public uint valueToAdd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			valueToAdd = s.Serialize<uint>(valueToAdd, name: "valueToAdd");
		}
		public override uint? ClassCRC => 0x0DF37C13;
	}
}

