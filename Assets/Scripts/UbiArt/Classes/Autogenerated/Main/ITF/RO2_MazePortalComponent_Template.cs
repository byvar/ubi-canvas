using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MazePortalComponent_Template : ActorComponent_Template {
		[Serialize("exitForce")] public float exitForce;
		[Serialize("radius"   )] public float radius;
		[Serialize("exitSpeed")] public float exitSpeed;
		[Serialize("maxFactor")] public float maxFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(exitForce));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(exitSpeed));
			SerializeField(s, nameof(maxFactor));
		}
		public override uint? ClassCRC => 0xB1E3FAC8;
	}
}

