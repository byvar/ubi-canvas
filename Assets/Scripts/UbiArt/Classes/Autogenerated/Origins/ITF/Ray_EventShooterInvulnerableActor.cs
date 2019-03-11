using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventShooterInvulnerableActor : CSerializable {
		[Serialize("invulnerable")] public bool invulnerable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invulnerable));
		}
		public override uint? ClassCRC => 0x6DB8F7EF;
	}
}

