using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StringWaveGeneratorComponent : ActorComponent {
		[Serialize("startsActivated")] public bool startsActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startsActivated));
			}
		}
		public override uint? ClassCRC => 0x2F55D408;
	}
}

