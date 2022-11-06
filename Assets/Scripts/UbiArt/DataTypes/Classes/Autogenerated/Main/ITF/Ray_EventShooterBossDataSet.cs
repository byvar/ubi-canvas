using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventShooterBossDataSet : Event {
		public int dataInt;
		public float dataFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dataInt = s.Serialize<int>(dataInt, name: "dataInt");
			dataFloat = s.Serialize<float>(dataFloat, name: "dataFloat");
		}
		public override uint? ClassCRC => 0xB7166F38;
	}
}

