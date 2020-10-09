using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class PlayWait_evtTemplate : SequenceEventWithActor_Template {
		public uint ContinueWith;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ContinueWith = s.Serialize<uint>(ContinueWith, name: "ContinueWith");
		}
		public override uint? ClassCRC => 0xA24B6930;
	}
}

