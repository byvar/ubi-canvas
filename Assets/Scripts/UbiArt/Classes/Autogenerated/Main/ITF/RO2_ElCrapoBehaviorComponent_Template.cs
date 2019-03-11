using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ElCrapoBehaviorComponent_Template : RO2_AIComponent_Template {
		[Serialize("jumpSpeed"             )] public float jumpSpeed;
		[Serialize("bounceSpeed"           )] public float bounceSpeed;
		[Serialize("bumperSpeed"           )] public float bumperSpeed;
		[Serialize("maxSpeed"              )] public float maxSpeed;
		[Serialize("airControl"            )] public float airControl;
		[Serialize("fullSpeedThreshold"    )] public float fullSpeedThreshold;
		[Serialize("dangerousContactHeight")] public float dangerousContactHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpSpeed));
			SerializeField(s, nameof(bounceSpeed));
			SerializeField(s, nameof(bumperSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(airControl));
			SerializeField(s, nameof(fullSpeedThreshold));
			SerializeField(s, nameof(dangerousContactHeight));
		}
		public override uint? ClassCRC => 0xFBCC8031;
	}
}

