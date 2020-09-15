using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class MetronomeManager_Template : TemplateObj {
		public uint defaultBPM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultBPM = s.Serialize<uint>(defaultBPM, name: "defaultBPM");
		}
		public override uint? ClassCRC => 0xB33FDC7C;
	}
}

