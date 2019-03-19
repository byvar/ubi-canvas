using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventCanBeVacuum : Event {
		[Serialize("canBeVaccumed")] public int canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canBeVaccumed));
		}
		public override uint? ClassCRC => 0x2E2C5C21;
	}
}

