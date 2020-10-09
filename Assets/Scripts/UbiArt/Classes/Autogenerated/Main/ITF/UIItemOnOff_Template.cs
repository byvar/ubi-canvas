using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class UIItemOnOff_Template : UIItemBasic_Template {
		public StringID animOn;
		public StringID animOff;
		public StringID animActivating;
		public StringID animActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animOn = s.SerializeObject<StringID>(animOn, name: "animOn");
			animOff = s.SerializeObject<StringID>(animOff, name: "animOff");
			animActivating = s.SerializeObject<StringID>(animActivating, name: "animActivating");
			animActive = s.SerializeObject<StringID>(animActive, name: "animActive");
		}
		public override uint? ClassCRC => 0x5961CA34;
	}
}

