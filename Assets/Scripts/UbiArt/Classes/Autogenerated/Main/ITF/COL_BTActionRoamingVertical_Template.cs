using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRoamingVertical_Template : CSerializable {
		public StringID name;
		public StringID animUp;
		public StringID animDown;
		public StringID animIdle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animUp = s.SerializeObject<StringID>(animUp, name: "animUp");
			animDown = s.SerializeObject<StringID>(animDown, name: "animDown");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
		}
		public override uint? ClassCRC => 0x549518B2;
	}
}

