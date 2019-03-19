using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_114_sub_A3AB50 : CSerializable {
		[Serialize("hasBeenVacuumed")] public int hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasBeenVacuumed));
		}
		public override uint? ClassCRC => 0x58E6FE8E;
	}
}

