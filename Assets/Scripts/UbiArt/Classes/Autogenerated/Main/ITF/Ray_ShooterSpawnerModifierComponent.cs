using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterSpawnerModifierComponent : TimedSpawnerModifierComponent {
		[Serialize("tweenId")] public Enum_RFR_0 tweenId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
		}
		public enum Enum_RFR_0 {
			[Serialize("invalid")] invalid = -1,
		}
		public override uint? ClassCRC => 0xBA1FFC13;
	}
}

