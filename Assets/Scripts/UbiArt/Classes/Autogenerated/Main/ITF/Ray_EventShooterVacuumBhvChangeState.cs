using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_EventShooterVacuumBhvChangeState : Event {
		[Serialize("state"    )] public uint state;
		[Serialize("spitForce")] public Vector2 spitForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(state));
				SerializeField(s, nameof(spitForce));
			} else {
				SerializeField(s, nameof(state));
			}
		}
		public override uint? ClassCRC => 0x804FEEEE;
	}
}

