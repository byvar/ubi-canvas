using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionActorOverlapSetFact_Template : BTAction_Template {
		[Serialize("factWithActor")] public StringID factWithActor;
		[Serialize("factOnOff"    )] public StringID factOnOff;
		[Serialize("invertTest"   )] public bool invertTest;
		[Serialize("overlapType"  )] public EOverlapType overlapType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factWithActor));
			SerializeField(s, nameof(factOnOff));
			SerializeField(s, nameof(invertTest));
			SerializeField(s, nameof(overlapType));
		}
		public enum EOverlapType {
			[Serialize("EOverlapType_Zone" )] Zone = 0,
			[Serialize("EOverlapType_Pivot")] Pivot = 1,
		}
		public override uint? ClassCRC => 0x39A73C99;
	}
}

