using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_CheckTimeSinceLastTrigger : RLC_Mission_Guard {
		[Serialize("timeSinceLastTrigger")] public float timeSinceLastTrigger;
		[Serialize("successCondition"    )] public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeSinceLastTrigger));
			SerializeField(s, nameof(successCondition));
		}
		public override uint? ClassCRC => 0x4CBC170B;
	}
}

