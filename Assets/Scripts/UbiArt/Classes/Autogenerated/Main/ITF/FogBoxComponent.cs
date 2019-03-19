using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class FogBoxComponent : ActorComponent {
		[Serialize("attenuationDist")] public Vector2 attenuationDist;
		[Serialize("near"           )] public float near;
		[Serialize("far"            )] public float far;
		[Serialize("nearColor"      )] public Color nearColor;
		[Serialize("farColor"       )] public Color farColor;
		[Serialize("useNearOffset"  )] public bool useNearOffset;
		[Serialize("ZWorldCliping"  )] public float ZWorldCliping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(attenuationDist));
				SerializeField(s, nameof(near));
				SerializeField(s, nameof(far));
				SerializeField(s, nameof(nearColor));
				SerializeField(s, nameof(farColor));
				SerializeField(s, nameof(useNearOffset));
				SerializeField(s, nameof(ZWorldCliping));
			}
		}
		public override uint? ClassCRC => 0xA466E579;
	}
}

