using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventSequenceEnableTrack : Event {
		public string trackName;
		public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			trackName = s.Serialize<string>(trackName, name: "trackName");
			enable = s.Serialize<bool>(enable, name: "enable");
		}
		public override uint? ClassCRC => 0x2B3A08F9;
	}
}

