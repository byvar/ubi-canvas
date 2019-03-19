using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LastPlayerTriggerComponent_Template : TriggerComponent_Template {
		[Serialize("useTimeBeforeActivation")] public int useTimeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useTimeBeforeActivation));
		}
		public override uint? ClassCRC => 0x959ED3E4;
	}
}

