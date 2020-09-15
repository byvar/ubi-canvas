using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL)]
	public partial class UISliderComponent_Template : UIItemBasic_Template {
		public float scaleOnSelected;
		public int isCursor;
		public Color colorOnSelected;
		public float speedCursor;
		public float scalefactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				scaleOnSelected = s.Serialize<float>(scaleOnSelected, name: "scaleOnSelected");
				isCursor = s.Serialize<int>(isCursor, name: "isCursor");
				colorOnSelected = s.SerializeObject<Color>(colorOnSelected, name: "colorOnSelected");
				speedCursor = s.Serialize<float>(speedCursor, name: "speedCursor");
			} else if (Settings.s.game == Settings.Game.RL) {
				scalefactor = s.Serialize<float>(scalefactor, name: "scalefactor");
				speedCursor = s.Serialize<float>(speedCursor, name: "speedCursor");
			} else {
			}
		}
		public override uint? ClassCRC => 0xD9999111;
	}
}

