using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIItemOnOff_Template : UIItemBasic_Template {
		[Serialize("animOn"        )] public StringID animOn;
		[Serialize("animOff"       )] public StringID animOff;
		[Serialize("animActivating")] public StringID animActivating;
		[Serialize("animActive"    )] public StringID animActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animOn));
			SerializeField(s, nameof(animOff));
			SerializeField(s, nameof(animActivating));
			SerializeField(s, nameof(animActive));
		}
		public override uint? ClassCRC => 0x5961CA34;
	}
}

