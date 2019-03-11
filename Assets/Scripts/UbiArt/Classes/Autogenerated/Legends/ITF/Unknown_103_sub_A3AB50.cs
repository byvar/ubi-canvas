using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_103_sub_A3AB50 : CSerializable {
		[Serialize("hasBeenVacuumed")] public bool hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasBeenVacuumed));
		}
		public override uint? ClassCRC => 0x58E6FE8E;
	}
}

