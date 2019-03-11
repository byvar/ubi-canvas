using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpecificBounceComponent : ActorComponent {
		[Serialize("angle"            )] public Angle angle;
		[Serialize("angleDelta"       )] public Angle angleDelta;
		[Serialize("multiplierMin"    )] public float multiplierMin;
		[Serialize("multiplierMax"    )] public float multiplierMax;
		[Serialize("multiplierDistMin")] public float multiplierDistMin;
		[Serialize("multiplierDistMax")] public float multiplierDistMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(angleDelta));
			SerializeField(s, nameof(multiplierMin));
			SerializeField(s, nameof(multiplierMax));
			SerializeField(s, nameof(multiplierDistMin));
			SerializeField(s, nameof(multiplierDistMax));
		}
		public override uint? ClassCRC => 0x2B4C0A42;
	}
}

