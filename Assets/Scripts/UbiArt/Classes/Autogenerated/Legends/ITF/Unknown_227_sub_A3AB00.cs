using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_227_sub_A3AB00 : CSerializable {
		[Serialize("canBeVaccumed")] public bool canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canBeVaccumed));
		}
		public override uint? ClassCRC => 0xCCA2EAC8;
	}
}

