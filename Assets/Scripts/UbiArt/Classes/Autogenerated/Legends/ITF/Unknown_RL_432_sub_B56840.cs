using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_432_sub_B56840 : CSerializable {
		[Serialize("rotatingPlatformPositionSmooth")] public Placeholder rotatingPlatformPositionSmooth;
		[Serialize("rotatingPlatformAngleSmooth"   )] public Placeholder rotatingPlatformAngleSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rotatingPlatformPositionSmooth));
			SerializeField(s, nameof(rotatingPlatformAngleSmooth));
		}
		public override uint? ClassCRC => 0xD8A100C4;
	}
}

