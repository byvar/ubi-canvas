using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTDeciderTargetInRangeToAttack_Template : BTDecider_Template {
		[Serialize("fact")] public StringID fact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
		}
		public override uint? ClassCRC => 0x027023F3;
	}
}

