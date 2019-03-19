using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventShooterBossDataSet : Event {
		[Serialize("dataInt"  )] public int dataInt;
		[Serialize("dataFloat")] public float dataFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dataInt));
			SerializeField(s, nameof(dataFloat));
		}
		public override uint? ClassCRC => 0x56C79B19;
	}
}

