using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Label_evtTemplate : SequenceEvent_Template {
		[Serialize("Label")] public string Label;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Label));
		}
		public override uint? ClassCRC => 0xB325916C;
	}
}

