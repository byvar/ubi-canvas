using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_CheckActiveTime : RLC_Mission_Guard {
		[Serialize("activeTime"      )] public float activeTime;
		[Serialize("successCondition")] public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activeTime));
			SerializeField(s, nameof(successCondition));
		}
		public override uint? ClassCRC => 0xBFFCDED0;
	}
}

