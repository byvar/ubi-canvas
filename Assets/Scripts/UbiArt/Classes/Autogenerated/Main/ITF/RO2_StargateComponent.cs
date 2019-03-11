using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StargateComponent : ActorComponent {
		[Serialize("doorOffset")] public Vector2 doorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(doorOffset));
			}
		}
		public override uint? ClassCRC => 0x683BEF32;
	}
}

