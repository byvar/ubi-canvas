using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_BezierCustomDistanceNodeComponent : ActorComponent {
		[Serialize("int__0")] public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
		}
		public override uint? ClassCRC => 0x5EA4F01D;
	}
}

