using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CreatureDetectorComponent_Template : ShapeDetectorComponent_Template {
		[Serialize("ignoreZ"           )] public bool ignoreZ;
		[Serialize("maxDetectionRadius")] public float maxDetectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ignoreZ));
			SerializeField(s, nameof(maxDetectionRadius));
		}
		public override uint? ClassCRC => 0xA94B3F0F;
	}
}

