using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionRemoveFact_Template : BTAction_Template {
		[Serialize("fact")] public StringID fact;
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fact));
			} else {
				SerializeField(s, nameof(fact));
			}
		}
		public override uint? ClassCRC => 0x3C45E762;
	}
}

