using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_240_sub_A3ABA0 : CSerializable {
		[Serialize("influenced")] public int influenced;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(influenced));
		}
		public override uint? ClassCRC => 0xB6919914;
	}
}

