using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class MetronomeManager_Template : TemplateObj {
		[Serialize("defaultBPM")] public uint defaultBPM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultBPM));
		}
		public override uint? ClassCRC => 0xB33FDC7C;
	}
}

