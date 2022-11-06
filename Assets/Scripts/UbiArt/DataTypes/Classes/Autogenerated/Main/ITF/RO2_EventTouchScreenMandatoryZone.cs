using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventTouchScreenMandatoryZone : Event {
		public bool enter;
		public bool unswapDRCPlayerIfSwapped;
		public bool autoMurphy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enter = s.Serialize<bool>(enter, name: "enter");
			unswapDRCPlayerIfSwapped = s.Serialize<bool>(unswapDRCPlayerIfSwapped, name: "unswapDRCPlayerIfSwapped");
			autoMurphy = s.Serialize<bool>(autoMurphy, name: "autoMurphy");
		}
		public override uint? ClassCRC => 0xF9AD72C0;
	}
}

