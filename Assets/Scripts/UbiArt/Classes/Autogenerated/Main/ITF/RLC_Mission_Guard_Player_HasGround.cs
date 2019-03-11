using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_Player_HasGround : RLC_Mission_Guard {
		[Serialize("hasGround")] public bool hasGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasGround));
		}
		public override uint? ClassCRC => 0xC9D1A137;
	}
}

