using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionHitTarget_Template : BTAction_Template {
		[Serialize("attacks"   )] public Placeholder attacks;
		[Serialize("fxBoneName")] public StringID fxBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attacks));
			SerializeField(s, nameof(fxBoneName));
		}
		public override uint? ClassCRC => 0x5EC4226C;
	}
}

