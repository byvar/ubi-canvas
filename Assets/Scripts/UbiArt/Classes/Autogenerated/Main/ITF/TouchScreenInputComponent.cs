using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TouchScreenInputComponent : ShapeComponent {
		public string viewName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.isCatchThemAll) {
				viewName = s.Serialize<string>(viewName, name: "viewName");
			}
		}
		public override uint? ClassCRC => 0x8F11DEDF;
	}
}

