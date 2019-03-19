using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class PhysComponent : ActorComponent {
		[Serialize("Mass"              )] public float Mass;
		[Serialize("Friction"          )] public float Friction;
		[Serialize("FrictionMultiplier")] public float FrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(Mass));
				SerializeField(s, nameof(Friction));
				SerializeField(s, nameof(FrictionMultiplier));
			}
		}
		public override uint? ClassCRC => 0x4CABF630;
	}
}

