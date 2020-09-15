using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventWantViewDRC : Event {
		public bool wantView;
		public bool cut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wantView = s.Serialize<bool>(wantView, name: "wantView");
			cut = s.Serialize<bool>(cut, name: "cut");
		}
		public override uint? ClassCRC => 0x762E1E4B;
	}
}

