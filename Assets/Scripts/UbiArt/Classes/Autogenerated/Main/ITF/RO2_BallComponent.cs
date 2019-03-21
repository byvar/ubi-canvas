using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BallComponent : ActorComponent {
		[Serialize("disableWindForce")] public bool disableWindForce;
		[Serialize("startWithHalo"   )] public bool startWithHalo;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(disableWindForce), boolAsByte: true);
					SerializeField(s, nameof(startWithHalo), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(disableWindForce));
					SerializeField(s, nameof(startWithHalo));
					SerializeField(s, nameof(bounceMultiplier));
				}
			}
		}
		public override uint? ClassCRC => 0x8499FE21;
	}
}

