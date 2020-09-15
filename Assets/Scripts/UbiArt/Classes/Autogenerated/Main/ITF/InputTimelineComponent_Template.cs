using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class InputTimelineComponent_Template : ActorComponent_Template {
		public uint TimelineMaxSize;
		public uint PeriodicalSendMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TimelineMaxSize = s.Serialize<uint>(TimelineMaxSize, name: "TimelineMaxSize");
			PeriodicalSendMax = s.Serialize<uint>(PeriodicalSendMax, name: "PeriodicalSendMax");
		}
		public override uint? ClassCRC => 0x124B4F4F;
	}
}

