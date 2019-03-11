using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderHasPlayerNear_Template : BTDecider_Template {
		[Serialize("fact"         )] public StringID fact;
		[Serialize("radius"       )] public float radius;
		[Serialize("detectionArea")] public StringID detectionArea;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(detectionArea));
		}
		public override uint? ClassCRC => 0x00F2FC64;
	}
}

