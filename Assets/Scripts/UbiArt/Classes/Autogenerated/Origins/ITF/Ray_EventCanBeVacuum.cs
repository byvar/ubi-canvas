using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventCanBeVacuum : CSerializable {
		[Serialize("canBeVaccumed")] public bool canBeVaccumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canBeVaccumed));
		}
		public override uint? ClassCRC => 0x2E2C5C21;
	}
}

