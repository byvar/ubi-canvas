using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionFindAttackTarget_Template : BTAction_Template {
		[Serialize("radius"        )] public float radius;
		[Serialize("fact"          )] public StringID fact;
		[Serialize("filterByHeight")] public int filterByHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(fact));
			SerializeField(s, nameof(filterByHeight));
		}
		public override uint? ClassCRC => 0x3B429E2D;
	}
}

