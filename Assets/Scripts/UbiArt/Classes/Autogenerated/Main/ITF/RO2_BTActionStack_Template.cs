using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionStack_Template : BTAction_Template {
		public StringID animStack;
		public StringID animStackTop;
		public StringID snapBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStack = s.SerializeObject<StringID>(animStack, name: "animStack");
			animStackTop = s.SerializeObject<StringID>(animStackTop, name: "animStackTop");
			snapBoneName = s.SerializeObject<StringID>(snapBoneName, name: "snapBoneName");
		}
		public override uint? ClassCRC => 0xC97C3B69;
	}
}

