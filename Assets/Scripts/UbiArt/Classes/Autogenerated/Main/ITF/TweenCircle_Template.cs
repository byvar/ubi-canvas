using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenCircle_Template : TweenTranslation_Template {
		[Serialize("pivot"     )] public Vector3 pivot;
		[Serialize("cycleCount")] public float cycleCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pivot));
			SerializeField(s, nameof(cycleCount));
		}
		public override uint? ClassCRC => 0x63707AC1;
	}
}

