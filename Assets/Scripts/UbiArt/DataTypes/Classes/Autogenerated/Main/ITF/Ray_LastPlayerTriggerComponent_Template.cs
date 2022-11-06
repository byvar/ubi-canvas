using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LastPlayerTriggerComponent_Template : TriggerComponent_Template {
		public int useTimeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useTimeBeforeActivation = s.Serialize<int>(useTimeBeforeActivation, name: "useTimeBeforeActivation");
		}
		public override uint? ClassCRC => 0x959ED3E4;
	}
}

