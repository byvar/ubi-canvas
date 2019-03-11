using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FallingObjectManagerComponent : ActorComponent {
		[Serialize("distance")] public float distance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(distance));
			}
		}
		public override uint? ClassCRC => 0xF321B497;
	}
}

