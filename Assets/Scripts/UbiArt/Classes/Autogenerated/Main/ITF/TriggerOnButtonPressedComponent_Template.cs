using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TriggerOnButtonPressedComponent_Template : TriggerComponent_Template {
		[Serialize("inputs")] public CList<uint> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0x655C4B1F;
	}
}

