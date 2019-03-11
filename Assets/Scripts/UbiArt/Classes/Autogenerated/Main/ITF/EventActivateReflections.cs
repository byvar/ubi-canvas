using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventActivateReflections : Event {
		[Serialize("RenderInReflections")] public bool RenderInReflections;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(RenderInReflections));
		}
		public override uint? ClassCRC => 0x95F380DD;
	}
}

