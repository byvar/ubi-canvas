using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuUplayPopUp_Template : UIItem_Template {
		[Serialize("translationTime")] public float translationTime;
		[Serialize("noTextTime"     )] public float noTextTime;
		[Serialize("textTime"       )] public float textTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(translationTime));
			SerializeField(s, nameof(noTextTime));
			SerializeField(s, nameof(textTime));
		}
		public override uint? ClassCRC => 0x2E88EB2A;
	}
}

