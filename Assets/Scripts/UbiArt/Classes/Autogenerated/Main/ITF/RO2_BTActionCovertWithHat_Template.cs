using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_BTActionCovertWithHat_Template : BTAction_Template {
		public StringID factTarget;
		public StringID animIdle;
		public StringID animStartCarrying;
		public StringID animStopCarrying;
		public StringID animCarrying;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factTarget = s.SerializeObject<StringID>(factTarget, name: "factTarget");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animStartCarrying = s.SerializeObject<StringID>(animStartCarrying, name: "animStartCarrying");
			animStopCarrying = s.SerializeObject<StringID>(animStopCarrying, name: "animStopCarrying");
			animCarrying = s.SerializeObject<StringID>(animCarrying, name: "animCarrying");
		}
		public override uint? ClassCRC => 0xB1082C39;
	}
}

