using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceEnableTrack : Event {
		[Serialize("trackName")] public string trackName;
		[Serialize("enable"   )] public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(trackName));
			SerializeField(s, nameof(enable));
		}
		public override uint? ClassCRC => 0x2B3A08F9;
	}
}

