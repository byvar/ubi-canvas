using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_TutoBallComponent_Template : ActorComponent_Template {
		[Serialize("tutoTapPath"  )] public Path tutoTapPath;
		[Serialize("tutoSwipePath")] public Path tutoSwipePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tutoTapPath));
			SerializeField(s, nameof(tutoSwipePath));
		}
		public override uint? ClassCRC => 0xC0641AF5;
	}
}

