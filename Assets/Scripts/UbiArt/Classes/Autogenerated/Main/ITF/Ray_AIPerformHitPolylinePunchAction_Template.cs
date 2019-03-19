using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIPerformHitPolylinePunchAction_Template : Ray_AIPerformHitAction_Template {
		[Serialize("dirOffset"      )] public Angle dirOffset;
		[Serialize("hitEnvironment" )] public int hitEnvironment;
		[Serialize("memorizeHitTime")] public float memorizeHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dirOffset));
			SerializeField(s, nameof(hitEnvironment));
			SerializeField(s, nameof(memorizeHitTime));
		}
		public override uint? ClassCRC => 0x7F519AE1;
	}
}

