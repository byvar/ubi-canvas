using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventInstructionDialogIsFinish : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE381DA8C;
	}
}

