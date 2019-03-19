using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventShooterBossDataSet : Event {
		[Serialize("dataInt"  )] public int dataInt;
		[Serialize("dataFloat")] public float dataFloat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dataInt));
			SerializeField(s, nameof(dataFloat));
		}
		public override uint? ClassCRC => 0xB7166F38;
	}
}

