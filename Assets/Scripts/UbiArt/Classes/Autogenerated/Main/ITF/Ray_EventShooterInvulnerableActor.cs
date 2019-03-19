using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventShooterInvulnerableActor : Event {
		[Serialize("invulnerable")] public int invulnerable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invulnerable));
		}
		public override uint? ClassCRC => 0x6DB8F7EF;
	}
}

