using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class EventSetWwiseSwitch : Event {
		public StringID WwiseSwitchGroupGUID;
		public StringID WwiseSwitchGUID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseSwitchGroupGUID = s.SerializeObject<StringID>(WwiseSwitchGroupGUID, name: "WwiseSwitchGroupGUID");
			WwiseSwitchGUID = s.SerializeObject<StringID>(WwiseSwitchGUID, name: "WwiseSwitchGUID");
		}
		public override uint? ClassCRC => 0x87CC5E51;
	}
}

