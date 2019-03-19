using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class InstructionDialogWait : InstructionDialog {
		[Serialize("time"   )] public float time;
		[Serialize("timeMin")] public float timeMin;
		[Serialize("timeMax")] public float timeMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(time));
			SerializeField(s, nameof(timeMin));
			SerializeField(s, nameof(timeMax));
		}
		public override uint? ClassCRC => 0x03259DFB;
	}
}

