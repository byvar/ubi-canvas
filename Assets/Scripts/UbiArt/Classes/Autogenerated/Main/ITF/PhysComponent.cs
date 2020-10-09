using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PhysComponent : ActorComponent {
		public float Mass;
		public float Friction;
		public float FrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else {
				Mass = s.Serialize<float>(Mass, name: "Mass");
				Friction = s.Serialize<float>(Friction, name: "Friction");
				FrictionMultiplier = s.Serialize<float>(FrictionMultiplier, name: "FrictionMultiplier");
			}
		}
		public override uint? ClassCRC => 0x4CABF630;
	}
}

