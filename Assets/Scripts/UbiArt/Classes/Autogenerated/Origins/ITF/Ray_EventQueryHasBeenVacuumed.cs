using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventQueryHasBeenVacuumed : CSerializable {
		[Serialize("hasBeenVacuumed")] public bool hasBeenVacuumed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasBeenVacuumed));
		}
		public override uint? ClassCRC => 0x88EF74D6;
	}
}

