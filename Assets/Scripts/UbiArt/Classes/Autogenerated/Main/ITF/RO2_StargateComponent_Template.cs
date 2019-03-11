using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StargateComponent_Template : ActorComponent_Template {
		[Serialize("detectShape" )] public Generic<PhysShape> detectShape;
		[Serialize("pressUpShape")] public Generic<PhysShape> pressUpShape;
		[Serialize("flashFX"     )] public Path flashFX;
		[Serialize("flashFXStart")] public Path flashFXStart;
		[Serialize("flashOffset" )] public Vector3 flashOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectShape));
			SerializeField(s, nameof(pressUpShape));
			SerializeField(s, nameof(flashFX));
			SerializeField(s, nameof(flashFXStart));
			SerializeField(s, nameof(flashOffset));
		}
		public override uint? ClassCRC => 0x59B9970A;
	}
}

