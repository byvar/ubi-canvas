using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayWait_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("ContinueWith")] public uint ContinueWith;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ContinueWith));
		}
		public override uint? ClassCRC => 0xA24B6930;
	}
}

