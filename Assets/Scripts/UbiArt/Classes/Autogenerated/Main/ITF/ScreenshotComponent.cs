using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ScreenshotComponent : ActorComponent {
		public bool useText;
		public bool useLogo;
		public bool useDRCView;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useText = s.Serialize<bool>(useText, name: "useText");
			useLogo = s.Serialize<bool>(useLogo, name: "useLogo");
			useDRCView = s.Serialize<bool>(useDRCView, name: "useDRCView");
		}
		public override uint? ClassCRC => 0x4D549084;
	}
}

