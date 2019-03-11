using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_DarktoonTrapHoleComponent_Template : CSerializable {
		[Serialize("anim")] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x429B9A87;
	}
}

