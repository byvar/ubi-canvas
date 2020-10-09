using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BTActionActorOverlapSetFact_Template : BTAction_Template {
		public StringID factWithActor;
		public StringID factOnOff;
		public bool invertTest;
		public EOverlapType overlapType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factWithActor = s.SerializeObject<StringID>(factWithActor, name: "factWithActor");
			factOnOff = s.SerializeObject<StringID>(factOnOff, name: "factOnOff");
			invertTest = s.Serialize<bool>(invertTest, name: "invertTest");
			overlapType = s.Serialize<EOverlapType>(overlapType, name: "overlapType");
		}
		public enum EOverlapType {
			[Serialize("EOverlapType_Zone" )] Zone = 0,
			[Serialize("EOverlapType_Pivot")] Pivot = 1,
		}
		public override uint? ClassCRC => 0x39A73C99;
	}
}

