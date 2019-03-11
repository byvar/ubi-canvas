using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIPerformHitPolylinePunchAction_Template : RO2_AIPerformHitAction_Template {
		[Serialize("dirOffset"      )] public Angle dirOffset;
		[Serialize("hitEnvironment" )] public bool hitEnvironment;
		[Serialize("memorizeHitTime")] public float memorizeHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dirOffset));
			SerializeField(s, nameof(hitEnvironment));
			SerializeField(s, nameof(memorizeHitTime));
		}
		public override uint? ClassCRC => 0x77EE31FB;
	}
}

