using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventQueryHasBeenVacuumed : Event {
		[Serialize("hasBeenVacuumed")] public int hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasBeenVacuumed));
		}
		public override uint? ClassCRC => 0x88EF74D6;
	}
}

