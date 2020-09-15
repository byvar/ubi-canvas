using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionHitTarget_Template : BTAction_Template {
		public Placeholder attacks;
		public StringID fxBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attacks = s.SerializeObject<Placeholder>(attacks, name: "attacks");
			fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
		}
		public override uint? ClassCRC => 0x5EC4226C;
	}
}

