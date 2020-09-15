using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BallComponent : ActorComponent {
		public bool disableWindForce;
		public bool startWithHalo;
		public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					disableWindForce = s.Serialize<bool>(disableWindForce, name: "disableWindForce", options: CSerializerObject.Options.BoolAsByte);
					startWithHalo = s.Serialize<bool>(startWithHalo, name: "startWithHalo", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					disableWindForce = s.Serialize<bool>(disableWindForce, name: "disableWindForce");
					startWithHalo = s.Serialize<bool>(startWithHalo, name: "startWithHalo");
					bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
				}
			}
		}
		public override uint? ClassCRC => 0x8499FE21;
	}
}

