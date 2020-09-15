using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL | GameFlags.RL)]
	public partial class ControlFilter : CSerializable {
		public ProceduralInputData input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<ProceduralInputData>(input, name: "input");
		}
		public override uint? ClassCRC => 0x70CBD0F6;
	}
}

