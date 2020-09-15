using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventShooterBossDataSet : Event {
		public int dataInt;
		public float dataFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dataInt = s.Serialize<int>(dataInt, name: "dataInt");
			dataFloat = s.Serialize<float>(dataFloat, name: "dataFloat");
		}
		public override uint? ClassCRC => 0x56C79B19;
	}
}

