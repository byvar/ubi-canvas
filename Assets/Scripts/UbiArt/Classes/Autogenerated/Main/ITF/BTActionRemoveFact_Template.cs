using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionRemoveFact_Template : BTAction_Template {
		public StringID fact;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fact = s.SerializeObject<StringID>(fact, name: "fact");
		}
		public override uint? ClassCRC => 0x3C45E762;
	}
}

