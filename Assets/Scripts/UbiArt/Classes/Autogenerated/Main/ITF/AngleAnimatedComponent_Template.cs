using UnityEngine;

namespace UbiArt.ITF {
	public partial class AngleAnimatedComponent_Template : ActorComponent_Template {
		[Serialize("CounterClockWise")] public bool CounterClockWise;
		[Serialize("AnimRotationName")] public StringID AnimRotationName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CounterClockWise));
			SerializeField(s, nameof(AnimRotationName));
		}
		public override uint? ClassCRC => 0x132C748D;
	}
}

