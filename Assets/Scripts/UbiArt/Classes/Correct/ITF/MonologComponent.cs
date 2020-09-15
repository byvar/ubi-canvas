using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class MonologComponent : DialogBaseComponent {
		public LocalisationId textID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				textID = s.SerializeChoiceListObject<LocalisationId>(textID, name: "textID", empty: "invalid");
			}
		}
		public override uint? ClassCRC => 0x0DB39EE4;
	}
}

