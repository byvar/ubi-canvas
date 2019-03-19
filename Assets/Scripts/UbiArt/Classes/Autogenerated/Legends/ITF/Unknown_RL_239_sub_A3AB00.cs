using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_239_sub_A3AB00 : CSerializable {
		[Serialize("canBeVaccumed")] public int canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canBeVaccumed));
		}
		public override uint? ClassCRC => 0xCCA2EAC8;
	}
}

