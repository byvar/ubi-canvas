using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianNodeAIComponent : ActorComponent {
		[Serialize("Enum_RFR_0__0")] public Enum_RFR_0 Enum_RFR_0__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_RFR_0__0));
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xCA2CCDCE;
	}
}

