using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionRemoveFact_Template : BTAction_Template {
		[Serialize("fact")] public StringID fact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fact));
		}
		public override uint? ClassCRC => 0x3C45E762;
	}
}

