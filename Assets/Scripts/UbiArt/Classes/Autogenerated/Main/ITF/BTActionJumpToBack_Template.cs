using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionJumpToBack_Template : BTAction_Template {
		[Serialize("anim"   )] public StringID anim;
		[Serialize("time"   )] public float time;
		[Serialize("zOffset")] public float zOffset;
		[Serialize("height" )] public float height;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
			SerializeField(s, nameof(time));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(height));
		}
		public override uint? ClassCRC => 0xA2C8211D;
	}
}

