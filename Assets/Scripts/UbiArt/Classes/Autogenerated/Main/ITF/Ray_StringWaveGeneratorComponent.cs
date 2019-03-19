using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StringWaveGeneratorComponent : CSerializable {
		[Serialize("startsActivated")] public int startsActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startsActivated));
			}
		}
		public override uint? ClassCRC => 0xA42F9D46;
	}
}

