using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudRepellerComponent : CSerializable {
		[Serialize("radiusMax"    )] public float radiusMax;
		[Serialize("radiusMin"    )] public float radiusMin;
		[Serialize("cycleDuration")] public float cycleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radiusMax));
			SerializeField(s, nameof(radiusMin));
			SerializeField(s, nameof(cycleDuration));
		}
		public override uint? ClassCRC => 0x2651A3EF;
	}
}

