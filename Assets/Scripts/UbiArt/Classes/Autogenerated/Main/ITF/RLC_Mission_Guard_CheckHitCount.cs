using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_CheckHitCount : RLC_Mission_Guard {
		[Serialize("hitCount"        )] public uint hitCount;
		[Serialize("successCondition")] public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitCount));
			SerializeField(s, nameof(successCondition));
		}
		public override uint? ClassCRC => 0x723ED840;
	}
}

