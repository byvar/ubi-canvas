using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_378_sub_B0CD30 : CSerializable {
		[Serialize("timedSpawnerData")] public Placeholder timedSpawnerData;
		[Serialize("fixedAngle"      )] public float fixedAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timedSpawnerData));
			SerializeField(s, nameof(fixedAngle));
		}
		public override uint? ClassCRC => 0x35663FAD;
	}
}

