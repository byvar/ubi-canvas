using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_LastPlayerTriggerComponent_Template : TriggerComponent_Template {
		[Serialize("useTimeBeforeActivation")] public bool useTimeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useTimeBeforeActivation));
		}
		public override uint? ClassCRC => 0x959ED3E4;
	}
}

