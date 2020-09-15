using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class MultiTextBoxComponent_Template : ActorComponent_Template {
		public CList<FontTextArea.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				styles = s.SerializeObject<CList<FontTextArea.Style>>(styles, name: "styles");
			}
		}
		public override uint? ClassCRC => 0x732EAD76;
	}
}

