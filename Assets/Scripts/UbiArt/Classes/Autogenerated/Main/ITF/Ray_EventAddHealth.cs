using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_EventAddHealth : Event {
		[Serialize("health")] public int health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(health));
		}
		public override uint? ClassCRC => 0x0660A7C6;
	}
}

