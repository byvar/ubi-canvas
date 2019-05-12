using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossMorayNodeComponent_Template : ActorComponent_Template {
		[Serialize("triggerEvent"      )] public Ray_EventBossMorayNodeReached triggerEvent;
		[Serialize("debugCorridorWidth")] public float debugCorridorWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggerEvent));
			SerializeField(s, nameof(debugCorridorWidth));
		}
		public override uint? ClassCRC => 0x4B2C34EF;
	}
}

