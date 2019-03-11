using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_StringWaveGeneratorComponent : CSerializable {
		[Serialize("startsActivated")] public bool startsActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startsActivated));
			}
		}
		public override uint? ClassCRC => 0xA42F9D46;
	}
}

