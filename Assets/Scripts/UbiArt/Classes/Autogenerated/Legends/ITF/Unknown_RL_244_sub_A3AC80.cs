using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_244_sub_A3AC80 : CSerializable {
		[Serialize("invulnerable")] public int invulnerable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(invulnerable));
		}
		public override uint? ClassCRC => 0x76C291E1;
	}
}

