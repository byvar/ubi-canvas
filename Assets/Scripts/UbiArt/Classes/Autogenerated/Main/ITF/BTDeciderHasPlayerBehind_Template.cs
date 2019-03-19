using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTDeciderHasPlayerBehind_Template : BTDecider_Template {
		[Serialize("radius"  )] public float radius;
		[Serialize("margin"  )] public float margin;
		[Serialize("invert"  )] public bool invert;
		[Serialize("checkAll")] public bool checkAll;
		[Serialize("factDir" )] public StringID factDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(margin));
			SerializeField(s, nameof(invert));
			SerializeField(s, nameof(checkAll));
			SerializeField(s, nameof(factDir));
		}
		public override uint? ClassCRC => 0x8998C34F;
	}
}

