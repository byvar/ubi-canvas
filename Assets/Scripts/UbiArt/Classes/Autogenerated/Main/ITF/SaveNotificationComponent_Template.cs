using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SaveNotificationComponent_Template : ActorComponent_Template {
		[Serialize("minDisplayingTime")] public float minDisplayingTime;
		[Serialize("relativepos"      )] public Vec2d relativepos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minDisplayingTime));
			SerializeField(s, nameof(relativepos));
		}
		public override uint? ClassCRC => 0x1D847FCF;
	}
}

