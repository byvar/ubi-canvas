using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayCheckInput_evtTemplate : SequenceEvent_Template {
		[Serialize("GotoLabel"    )] public string GotoLabel;
		[Serialize("ActionToCheck")] public StringID ActionToCheck;
		[Serialize("IsLooping"    )] public bool IsLooping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(GotoLabel));
			SerializeField(s, nameof(ActionToCheck));
			SerializeField(s, nameof(IsLooping));
		}
		public override uint? ClassCRC => 0x01B7B2F1;
	}
}

