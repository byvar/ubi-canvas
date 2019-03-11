using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpikyBallComponent : ActorComponent {
		[Serialize("torqueFriction"       )] public float torqueFriction;
		[Serialize("airFrictionMultiplier")] public float airFrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(torqueFriction));
			SerializeField(s, nameof(airFrictionMultiplier));
		}
		public override uint? ClassCRC => 0x80EF4FD3;
	}
}

