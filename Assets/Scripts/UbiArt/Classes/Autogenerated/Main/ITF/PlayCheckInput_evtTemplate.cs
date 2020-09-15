using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlayCheckInput_evtTemplate : SequenceEvent_Template {
		public string GotoLabel;
		public StringID ActionToCheck;
		public bool IsLooping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GotoLabel = s.Serialize<string>(GotoLabel, name: "GotoLabel");
			ActionToCheck = s.SerializeObject<StringID>(ActionToCheck, name: "ActionToCheck");
			IsLooping = s.Serialize<bool>(IsLooping, name: "IsLooping");
		}
		public override uint? ClassCRC => 0x01B7B2F1;
	}
}

