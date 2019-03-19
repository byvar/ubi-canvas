using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class InputTimelineComponent_Template : ActorComponent_Template {
		[Serialize("TimelineMaxSize"  )] public uint TimelineMaxSize;
		[Serialize("PeriodicalSendMax")] public uint PeriodicalSendMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TimelineMaxSize));
			SerializeField(s, nameof(PeriodicalSendMax));
		}
		public override uint? ClassCRC => 0x124B4F4F;
	}
}

