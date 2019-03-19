using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventWantViewDRC : Event {
		[Serialize("wantView")] public bool wantView;
		[Serialize("cut"     )] public bool cut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(wantView));
			SerializeField(s, nameof(cut));
		}
		public override uint? ClassCRC => 0x762E1E4B;
	}
}

