using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionFollowTarget_Template : BTActionWalkToTarget_Template {
		[Serialize("range"       )] public float range;
		[Serialize("followTarget")] public StringID followTarget;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(range));
			SerializeField(s, nameof(followTarget));
		}
		public override uint? ClassCRC => 0x41F81535;
	}
}

