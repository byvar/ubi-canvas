using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIMenuUplayPopUp_Template : UIItem_Template {
		public float translationTime;
		public float noTextTime;
		public float textTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			translationTime = s.Serialize<float>(translationTime, name: "translationTime");
			noTextTime = s.Serialize<float>(noTextTime, name: "noTextTime");
			textTime = s.Serialize<float>(textTime, name: "textTime");
		}
		public override uint? ClassCRC => 0x2E88EB2A;
	}
}

