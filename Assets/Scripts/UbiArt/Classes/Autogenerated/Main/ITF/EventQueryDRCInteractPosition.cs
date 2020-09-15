using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventQueryDRCInteractPosition : Event {
		[Serialize("position")] public Vec2d position;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(position));
		}
		public override uint? ClassCRC => 0x03B0E285;
	}
}

