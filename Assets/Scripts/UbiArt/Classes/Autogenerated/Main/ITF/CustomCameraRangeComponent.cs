using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CustomCameraRangeComponent : ActorComponent {
		[Serialize("updateFrustumEnlargeRange" )] public float updateFrustumEnlargeRange;
		[Serialize("loadingFrustumEnlargeRange")] public float loadingFrustumEnlargeRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(updateFrustumEnlargeRange));
			SerializeField(s, nameof(loadingFrustumEnlargeRange));
		}
		public override uint? ClassCRC => 0x9B9C5D7D;
	}
}

