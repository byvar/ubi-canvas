using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ExtraLumsComponent : ActorComponent {
		[Serialize("disappearStartTime"   )] public float disappearStartTime;
		[Serialize("disappearIntervalTime")] public float disappearIntervalTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(disappearStartTime));
				SerializeField(s, nameof(disappearIntervalTime));
			}
		}
		public override uint? ClassCRC => 0x8A1EAD12;
	}
}

