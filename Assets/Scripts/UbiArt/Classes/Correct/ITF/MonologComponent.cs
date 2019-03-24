using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class MonologComponent : DialogBaseComponent {
		[Serialize("textID")] public LocalisationId textID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeFieldAsChoiceList(s, nameof(textID), "invalid");
			}
		}
		public override uint? ClassCRC => 0x0DB39EE4;
	}
}

