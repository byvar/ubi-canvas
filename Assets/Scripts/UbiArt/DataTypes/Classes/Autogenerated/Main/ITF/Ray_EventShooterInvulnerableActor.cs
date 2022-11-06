using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventShooterInvulnerableActor : Event {
		public int invulnerable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invulnerable = s.Serialize<int>(invulnerable, name: "invulnerable");
		}
		public override uint? ClassCRC => 0x6DB8F7EF;
	}
}

