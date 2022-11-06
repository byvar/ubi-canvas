using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterSpawnerModifierComponent : TimedSpawnerModifierComponent {
		public Enum_RFR_0 tweenId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tweenId = s.Serialize<Enum_RFR_0>(tweenId, name: "tweenId");
		}
		public enum Enum_RFR_0 {
			[Serialize("invalid")] invalid = -1,
		}
		public override uint? ClassCRC => 0xBA1FFC13;
	}
}

