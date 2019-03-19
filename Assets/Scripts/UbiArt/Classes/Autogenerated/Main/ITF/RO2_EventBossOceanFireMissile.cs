using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventBossOceanFireMissile : Event {
		[Serialize("regionIndex")] public uint regionIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(regionIndex));
		}
		public override uint? ClassCRC => 0x1511D2A6;
	}
}

