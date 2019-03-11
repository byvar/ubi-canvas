using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysComponent : ActorComponent {
		[Serialize("Mass"              )] public float Mass;
		[Serialize("Friction"          )] public float Friction;
		[Serialize("FrictionMultiplier")] public float FrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(Mass));
				SerializeField(s, nameof(Friction));
				SerializeField(s, nameof(FrictionMultiplier));
			}
		}
		public override uint? ClassCRC => 0x4CABF630;
	}
}

