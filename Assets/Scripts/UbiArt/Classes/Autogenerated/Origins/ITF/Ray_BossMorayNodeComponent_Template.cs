using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BossMorayNodeComponent_Template : CSerializable {
		[Serialize("triggerEvent"      )] public Placeholder triggerEvent;
		[Serialize("debugCorridorWidth")] public float debugCorridorWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggerEvent));
			SerializeField(s, nameof(debugCorridorWidth));
		}
		public override uint? ClassCRC => 0x4B2C34EF;
	}
}

