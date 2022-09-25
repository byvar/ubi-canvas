using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MultiTextBoxComponent_Template : ActorComponent_Template {
		public CListO<FontTextArea.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
			} else {
				styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
			}
		}
		public override uint? ClassCRC => 0x732EAD76;
	}
}

