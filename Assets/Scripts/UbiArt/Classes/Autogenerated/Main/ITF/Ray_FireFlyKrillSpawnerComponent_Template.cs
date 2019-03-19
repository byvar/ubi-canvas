using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_FireFlyKrillSpawnerComponent_Template : CSerializable {
		[Serialize("krillActorPath" )] public Path krillActorPath;
		[Serialize("detectionRadius")] public float detectionRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(krillActorPath));
			SerializeField(s, nameof(detectionRadius));
		}
		public override uint? ClassCRC => 0xB9AD0DA6;
	}
}

