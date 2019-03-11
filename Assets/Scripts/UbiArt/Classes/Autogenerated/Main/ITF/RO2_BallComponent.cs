using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BallComponent : ActorComponent {
		[Serialize("disableWindForce")] public bool disableWindForce;
		[Serialize("startWithHalo"   )] public bool startWithHalo;
		[Serialize("bounceMultiplier")] public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(disableWindForce));
					SerializeField(s, nameof(startWithHalo));
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

